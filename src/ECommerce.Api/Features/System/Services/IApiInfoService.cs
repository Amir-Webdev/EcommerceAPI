using ECommerce.Api.Features.System.DTOs;

namespace ECommerce.Api.Features.System.Services;

public interface IApiInfoService
{
    ApiInfoResponse GetApiInfo();
}