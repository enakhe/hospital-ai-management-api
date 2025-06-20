using HospitalManagement.Application.Common.Security;
using HospitalManagement.Application.Common.Services.AIIntegration;
using HospitalManagement.Domain.Entities.AIIntegration;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Web.Controllers.AIIntegraton;

[ApiController]
[Route("api/ai/diagnosis")]
[Authorize(Roles = "Administrator")]
public class DiagnosisController(DiagnosisService service) : ControllerBase
{
    private readonly DiagnosisService _service = service;

    [HttpPost]
    public async Task<IActionResult> Diagnose([FromBody] DiagnosisRequest request)
    {
        var result = await _service.GetDiagnosisAsync(request);
        return result is not null ? Ok(result) : StatusCode(500, "AI module error");
    }
}
