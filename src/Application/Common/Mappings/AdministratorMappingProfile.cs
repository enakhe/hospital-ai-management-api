﻿using HospitalManagement.Application.Common.DTOs.Administrator;
using HospitalManagement.Domain.Entities.Administrator;
using HospitalManagement.Domain.Entities.Configuration;
using HospitalManagement.Domain.Entities.Data;

namespace HospitalManagement.Application.Common.Mappings;
public class AdministratorMappingProfile : Profile
{
    public AdministratorMappingProfile()
    {
        // User mappings
        CreateMap<ApplicationUser, UserDto>()
            .ForMember(dest => dest.Roles, opt => opt.Ignore())
            .ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => src.Branch!.Name));

        CreateMap<CreateUserDto, ApplicationUser>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.EmailConfirmed, opt => opt.MapFrom(src => false))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(_ => true));

        CreateMap<UpdateUserDto, ApplicationUser>()
                .ForMember(dest => dest.LastUpdatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow));

        // Role mappings
        CreateMap<ApplicationRole, RoleDto>()
            .ForMember(dest => dest.Permissions, opt => opt.Ignore());

        CreateMap<CreateRoleDto, ApplicationRole>();

        // Permission mappings
        CreateMap<Permission, PermissionDto>();

        // Branch mappings
        CreateMap<CreateBranchDto, Branch>();
        CreateMap<Branch, BranchDto>();

        // Audit log mappings
        CreateMap<AuditLog, AuditLogDto>()
            .ForMember(dest => dest.UserEmail, opt => opt.MapFrom(src => src.User.Email))
            .ForMember(dest => dest.Changes, opt => opt.MapFrom(src => src.PropertyChanges));

        CreateMap<AuditLogDetail, AuditLogDetailDto>();
    }
}
