using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace CodePulse.API.Models.DTO
{
    public class UpdateCategoryRequestDto
    {
        public string Name {  get; set; }
        public string UrlHandle { get; set; }
    }
}
