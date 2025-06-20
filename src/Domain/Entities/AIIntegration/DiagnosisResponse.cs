using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Domain.Entities.AIIntegration;
public class DiagnosisResponse
{
    public required string Symptoms { get; set; }
    public int? Age { get; set; }
    public required string Gender { get; set; }
    public required string History { get; set; }
}
