
using BaseLibrary.DTOs;

using BaseLibrary.Responses;
using ClientLibrary.Helpers;
using ClientLibrary.Services.Contracts;
using System.Net.Http.Json;



namespace ClientLibrary.Services.Implementations;



public class UserAccountService : IUserAccountService
{
    public const string AuthUrl = "api/authentication";
    private readonly GetHttpClient getHttpClient;

    public UserAccountService(GetHttpClient getHttpClient)
    {
        this.getHttpClient = getHttpClient;
    }

    public async Task<GeneralResponse> CreateAsync(Register user)
    {

        try
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PostAsJsonAsync($"{AuthUrl}/register", user);
            if (!result.IsSuccessStatusCode) return new GeneralResponse(false, "Error occured");

            return await result.Content.ReadFromJsonAsync<GeneralResponse>()!;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }


    public async Task<LoginResponse> SignInAsync(Login user)
    {

        try
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PostAsJsonAsync($"{AuthUrl}/login", user);
            if (!result.IsSuccessStatusCode) return new LoginResponse(false, "Error occured");

            return await result.Content.ReadFromJsonAsync<LoginResponse>()!;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }


    public async Task<LoginResponse> RefreshTokenAsync(RefreshToken token)
    {

        try
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PostAsJsonAsync($"{AuthUrl}/refresh-token", token);
            if (!result.IsSuccessStatusCode) return new LoginResponse(false, "Error occured");

            return await result.Content.ReadFromJsonAsync<LoginResponse>()!;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }



    //public async Task<WeatherForecast[]> GetWheaterForecasts()
    //{

    //    try
    //    {
    //        var httpClient = getHttpClient.GetPrivateHttpClient();
    //        var result = await httpClient.GetFromJsonAsync<WeatherForecast[]>("api/weatherforecast");
    //        return result!;
    //    }
    //    catch (Exception e)
    //    {
    //        Console.WriteLine(e);
    //        throw;
    //    }

    //}

    public async Task<WeatherForecast[]> GetWheaterForecasts()
    {
        try
        {
            var httpClient = await getHttpClient.GetPrivateHttpClient();
            var result = await httpClient.GetFromJsonAsync<WeatherForecast[]>("api/weatherforecast");
            return result!;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    //public async Task<WeatherForecast[]> GetWheaterForecasts()
    //{
    //    try
    //    {
    //        var httpClient = getHttpClient.GetPublicHttpClient();

    //        if (string.IsNullOrEmpty(_token))
    //        {
    //            throw new InvalidOperationException("No token available for authorization.");
    //        }

    //        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

    //        var result = await httpClient.GetFromJsonAsync<WeatherForecast[]>("api/WeatherForecast");
    //        return result!;
    //    }
    //    catch (Exception e)
    //    {
    //        Console.WriteLine(e);
    //        throw;
    //    }
    //}


}
