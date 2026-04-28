using ECommerce.Api.Common.Models;

namespace ECommerce.Api.Features.Categories.Models;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }
}