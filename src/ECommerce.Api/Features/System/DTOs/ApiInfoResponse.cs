namespace ECommerce.Api.Features.System.DTOs;

public class ApiInfoResponse
{
    public string AppName { get; set; } = string.Empty;

    public string Version { get; set; } = string.Empty;

    public string EnvironmentName { get; set; } = string.Empty;

    public string Status {get; set; } = string.Empty;

    public DateTime ServerTimeUtc { get; set; }
}