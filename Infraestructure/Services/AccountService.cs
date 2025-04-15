using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;
using Microsoft.AspNetCore.Identity;



namespace Infraestructure.Services;



public class AccountService : IAccountService
{

    private readonly SignInManager<User> _signInManager;
    private readonly IUnitOfWork _unitOfWork;

    public AccountService(SignInManager<User> signInManager, IUnitOfWork unitOfWork)
    {
        this._signInManager = signInManager;
        this._unitOfWork = unitOfWork;
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

        return new BaseResponse
        {
            IsSuccess = result.Succeeded
        };

    }


    public async Task<BaseResponse<string>> VerifyUser(string email, string password)
    {
        
        BaseResponse<string> response = new();

        var user = await _signInManager.UserManager.FindByEmailAsync(email);
        if (user == null)
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

        return _unitOfWork.Repository<User>().ListAll().Select(x => new GetUserResponse
        {
            Id = x.Id,
            Email = x.Email,
            Avatar = x.Avatar
        }).ToList();
        
    }


}
