﻿using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.Security.Entities;
using CRM.Application.Features.OperationClaims.Constants;
using CRM.Application.Features.OperationClaims.Rules;
using CRM.Application.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static CRM.Application.Features.OperationClaims.Constants.OperationClaimsOperationClaims;

namespace CRM.Application.Features.OperationClaims.Commands.Delete;

public class DeleteOperationClaimCommand : IRequest<DeletedOperationClaimResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new[] { Admin, Write, OperationClaimsOperationClaims.Delete };

    public class DeleteOperationClaimCommandHandler : IRequestHandler<DeleteOperationClaimCommand, DeletedOperationClaimResponse>
    {
        private readonly IOperationClaimRepository _operationClaimRepository;
        private readonly IMapper _mapper;
        private readonly OperationClaimBusinessRules _operationClaimBusinessRules;

        public DeleteOperationClaimCommandHandler(
            IOperationClaimRepository operationClaimRepository,
            IMapper mapper,
            OperationClaimBusinessRules operationClaimBusinessRules
        )
        {
            _operationClaimRepository = operationClaimRepository;
            _mapper = mapper;
            _operationClaimBusinessRules = operationClaimBusinessRules;
        }

        public async Task<DeletedOperationClaimResponse> Handle(DeleteOperationClaimCommand request, CancellationToken cancellationToken)
        {
            OperationClaim? operationClaim = await _operationClaimRepository.GetAsync(
                predicate: oc => oc.Id == request.Id,
                include: q => q.Include(oc => oc.UserOperationClaims),
                cancellationToken: cancellationToken
            );
            await _operationClaimBusinessRules.OperationClaimShouldExistWhenSelected(operationClaim);

            await _operationClaimRepository.DeleteAsync(entity: operationClaim!);

            DeletedOperationClaimResponse response = _mapper.Map<DeletedOperationClaimResponse>(operationClaim);
            return response;
        }
    }
}
