using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Domain.Entities.AIIntegration;
public class DiagnosisResponse
{
    public required List<Prediction> Predictions { get; set; }
    public required string Advice { get; set; }
}

public class Prediction
{
    public required string Condition { get; set; }
    public double Confidence { get; set; }
}
