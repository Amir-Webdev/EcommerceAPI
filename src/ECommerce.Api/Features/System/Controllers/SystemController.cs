using ECommerce.Api.Features.System.DTOs;
using ECommerce.Api.Features.System.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Features.System.Controllers;

[ApiController]
[Route("api/system")]
public class SystemController : ControllerBase
{
  private readonly IApiInfoService _apiInfoService;

  public SystemController(IApiInfoService apiInfoService) 
  {
    _apiInfoService = apiInfoService;
  }

  [HttpGet("info")]
  public ActionResult<ApiInfoResponse> GetInfo()
  {
    ApiInfoResponse response = _apiInfoService.GetApiInfo();
    return Ok(response);
  }

  [HttpGet("echo/{message}")]
  public IActionResult Echo(string message, [FromQuery] string? name, [FromQuery] string? lastName)
  {
    return Ok(new
    {
      Message = message,
      Name = name,
      LastName = lastName,
      ServerTimeUtc = DateTime.UtcNow
    });
  }
}