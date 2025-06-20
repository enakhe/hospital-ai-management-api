using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Domain.Entities.AIIntegration;
using Microsoft.Extensions.Configuration;

namespace HospitalManagement.Application.Common.Services.AIIntegration;
public class DiagnosisService(HttpClient httpClient, IConfiguration config)
{
    private readonly HttpClient _httpClient = httpClient;
    private readonly IConfiguration _config = config;

    public async Task<DiagnosisResponse?> GetDiagnosisAsync(DiagnosisRequest request)
    {
        var apiUrl = _config["FastApi:DiagnosisUrl"]; 

        var response = await _httpClient.PostAsJsonAsync(apiUrl, request);

        return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<DiagnosisResponse>() : null;
    }
}
