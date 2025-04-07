﻿using BaseLibrary.DTOs;
using BaseLibrary.Responses;



namespace ClientLibrary.Services.Contracts;



/// <summary>
/// Interface for user account service.
/// </summary>
public interface IUserAccountService
{

    Task<GeneralResponse> CreateAsync(Register user);

    Task<LoginResponse> SignInAsync(Login user);

    Task<LoginResponse> RefreshTokenAsync(RefreshToken token);

    Task<WeatherForecast[]> GetWheaterForecasts();

}