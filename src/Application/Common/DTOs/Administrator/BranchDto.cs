﻿namespace HospitalManagement.Application.Common.DTOs.Administrator;
public class BranchDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? ContactNumber { get; set; }
    public string? Email { get; set; }
    public string? TimeZone { get; set; }
    public string? CurrencyCode { get; set; }
    public bool IsActive { get; set; }
}
