using System.Security.Claims;
using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;



namespace Infraestructure.Services;



public class AccountService : IAccountService
{

    private readonly SignInManager<User> _signInManager;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IHttpContextAccessor _httpContextAccessor;

    private readonly IWebHostEnvironment _environment;

    public AccountService(SignInManager<User> signInManager,
                            IUnitOfWork unitOfWork,
                            IHttpContextAccessor httpContextAccessor,
                            IWebHostEnvironment environment)
    {
        this._signInManager = signInManager;
        this._unitOfWork = unitOfWork;
        this._httpContextAccessor = new HttpContextAccessor();
        this._environment = environment;
    }


    public async Task<BaseResponse> RegisterUser(RegisterUserRequest request)
    {

        User user = new User
        {
            UserName = request.Email,
            Email = request.Email,
            AccountConfirmed = false
        };

        string password = Constants.DEFAULT_PASSWORD;

        var result = await _signInManager.UserManager.CreateAsync(user, password);

        if (result.Succeeded)
        {
            await _signInManager.UserManager.AddToRoleAsync(user, request.Role);

            return new BaseResponse
            {
                IsSuccess = true
            };
        }
        else
        {
            return new BaseResponse
            {
                IsSuccess = false,
                ErrorMessage = result.Errors.FirstOrDefault()?.Description
            };
        }
    }


    public async Task<BaseResponse<string>> VerifyUser(string email, string password)
    {

        BaseResponse<string> response = new();

        var user = await _signInManager.UserManager.FindByEmailAsync(email);
        if (user == null || user.IsDeleted)
        {
            response.IsSuccess = false;
            response.ErrorMessage = "User not found";
            return response;
        }

        var result = await _signInManager.UserManager.CheckPasswordAsync(user, password);
        response.IsSuccess = result;
        if (!result)
        {
            response.ErrorMessage = "Invalid Email/password";
        }
        else
        {
            response.Value = user.UserName;
        }

        return response;

    }


    public List<GetUserResponse> GetUsers()
    {

        var roles = _unitOfWork.Repository<IdentityUserRole<string>>().ListAll()
            .Select(x => new
            {
                x.UserId,
                x.RoleId,
                Role = Constants.UserRoles[x.RoleId]
            });


        return _unitOfWork.Repository<User>().ListAll()
                .Where(x => x.IsDeleted == false)
                .Select(x => new GetUserResponse
                {
                    Id = x.Id,
                    Email = x.Email,
                    Avatar = x.Avatar,
                    Role = roles.FirstOrDefault(r => r.UserId == x.Id)?.Role,
                    AccountConfirmed = x.AccountConfirmed,
                }).ToList();

    }


    public async Task<BaseResponse<User>> GetCurrentUser()
    {

        BaseResponse<User> response = new BaseResponse<User>();

        response.IsSuccess = false;

        var currentUser = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;
        if (currentUser == null)
        {
            response.ErrorMessage = "Invalid User Account!";
            return response;
        }

        var user = await _signInManager.UserManager.FindByEmailAsync(currentUser);
        if (user == null)
        {
            response.ErrorMessage = "Invalid User Account!";
            return response;
        }

        response.IsSuccess = true;
        response.Value = user;
        return response;

    }


    public async Task<BaseResponse> ChangePassword(ChangePasswordRequest request)
    {

        BaseResponse response = new BaseResponse();
        response.IsSuccess = false;

        var user = await GetCurrentUser();
        if (!user.IsSuccess)
        {
            response.ErrorMessage = user.ErrorMessage;
            return response;
        }

        var changePassResult = await _signInManager.UserManager.ChangePasswordAsync(user.Value, request.CurrentPassword, request.NewPassword);

        if (changePassResult.Succeeded)
        {
            response.IsSuccess = true;
            await ConfirmAccount(user.Value);
        }
        else
        {
            response.ErrorMessage = changePassResult.Errors.FirstOrDefault()?.Description;
        }

        return response;

    }


    private async Task ConfirmAccount(User user)
    {
        if (user.AccountConfirmed == false)
        {
            user.AccountConfirmed = true;
            _unitOfWork.Repository<User>().Update(user);
            await _unitOfWork.SaveChanges();
        }
    }


    public async Task<BaseResponse> RemoveUser(string email)
    {
        BaseResponse response = new BaseResponse();
        response.IsSuccess = false;

        var user = await _signInManager.UserManager.FindByEmailAsync(email);
        if (user == null)
        {
            response.ErrorMessage = "User not found - " + email;
            return response;
        }

        user.IsDeleted = true;
        var result = await _signInManager.UserManager.UpdateAsync(user);
        if (!result.Succeeded)
        {
            response.ErrorMessage = result.Errors.FirstOrDefault().Description;

        }
        response.IsSuccess = true;
        return response;
    }


    public async Task<BaseResponse<string>> UploadAvatar(IBrowserFile image)
    {
        BaseResponse<string> response = new BaseResponse<string>();
        response.IsSuccess = false;
        string previousAvatar;
        var uploadPath = Path.Combine(_environment.WebRootPath, "uploads", "avatar");

        var currentUser = await GetCurrentUser();
        if (!currentUser.IsSuccess)
        {
            response.ErrorMessage = currentUser.ErrorMessage;
            return response;
        }

        if (image != null)
        {
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            if (currentUser.Value.Avatar != null && currentUser.Value.Avatar != Constants.DEFAULT_AVATAR)
            {
                previousAvatar = currentUser.Value.Avatar;
                previousAvatar = Path.Combine(uploadPath, previousAvatar);
                if (File.Exists(previousAvatar))
                {
                    File.Delete(previousAvatar);
                }
            }

            var fileExtension = Path.GetExtension(image.Name);
            string fileName = $"{currentUser.Value.Email}{fileExtension}";
            var filePath = Path.Combine(uploadPath, fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await image.OpenReadStream().CopyToAsync(fileStream);
            }

            currentUser.Value.Avatar = fileName;
            var updateResult = await _signInManager.UserManager.UpdateAsync(currentUser.Value);
            if (updateResult.Succeeded)
            {
                response.IsSuccess = true;
                response.Value = fileName;
            }
            else
            {
                response.ErrorMessage = updateResult.Errors.FirstOrDefault()?.Description;
            }

        }

        return response;

    }


    public async Task<BaseResponse> ResetAvatar()
    {

        BaseResponse response = new BaseResponse();
        response.IsSuccess = false;
        var uploadPath = Path.Combine(_environment.WebRootPath, "uploads", "avatar");

        var currentUser = await GetCurrentUser();
        if (!currentUser.IsSuccess)
        {
            response.ErrorMessage = currentUser.ErrorMessage;
            return response;
        }

        string previousAvatar;

        if (currentUser.Value.Avatar != Constants.DEFAULT_AVATAR)
        {
            previousAvatar = currentUser.Value.Avatar;

            if (!string.IsNullOrEmpty(previousAvatar))
            {
                previousAvatar = Path.Combine(uploadPath, previousAvatar);
                if (File.Exists(previousAvatar))
                {
                    File.Delete(previousAvatar);
                }
            }

            currentUser.Value.Avatar = Constants.DEFAULT_AVATAR;
            var updateResult = await _signInManager.UserManager.UpdateAsync(currentUser.Value);
            if (updateResult.Succeeded)
            {
                response.IsSuccess = true;
            }
            else
            {
                response.ErrorMessage = updateResult.Errors.FirstOrDefault()?.Description;
            }
        }

        return response;

    }
    

}
