﻿using System.ComponentModel.DataAnnotations;
using HospitalManagement.Application.Common.Interfaces.Administrator;

namespace HospitalManagement.Application.Branches.Commands;

public record DeleteBranchCommand : IRequest
{
    [Required]
    public required Guid Id { get; set; }
}

public class DeleteBranchCommandHandler(IBranchService branchService) : IRequestHandler<DeleteBranchCommand>
{
    private readonly IBranchService _branchService = branchService;

    public async Task Handle(DeleteBranchCommand request, CancellationToken cancellationToken)
    {
        await _branchService.DeleteBranchAsync(request.Id);
    }
}
