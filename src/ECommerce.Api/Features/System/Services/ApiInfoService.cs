using ECommerce.Api.Features.System.DTOs;

namespace ECommerce.Api.Features.System.Services;

public class ApiInfoService : IApiInfoService
{
    private readonly IHostEnvironment _environment;

    public ApiInfoService(IHostEnvironment environment)
    {
        _environment = environment;
    }

    public ApiInfoResponse GetApiInfo()
    {
        return new ApiInfoResponse
        {
            AppName = "ECommerce API",
            Version = "1.0.0",
            EnvironmentName = _environment.EnvironmentName,
            Status = "Running",
            ServerTimeUtc = DateTime.UtcNow
        };
    }
}