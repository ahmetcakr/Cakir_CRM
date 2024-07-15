﻿using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.CrossCuttingConcerns.Exceptions.Types;
using CRM.Application.Features.CompanyTypes.Constants;
using CRM.Application.Features.CompanyTypes.Rules;
using CRM.Application.Repositories;
using CRM.Domain.Entities;
using MediatR;
using static CRM.Application.Features.CompanyTypes.Constants.CompanyTypesOperationClaims;

namespace CRM.Application.Features.CompanyTypes.Commands.Delete;

public class DeleteCompanyTypeCommand : IRequest<DeletedCompanyTypeResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new[]
    {
        Admin,
        CompanyTypesOperationClaims.Delete,
        Write
    };

    public class DeleteCompanyCommandHandler(
        ICompanyTypeRepository companyTypeRepository,
        CompanyTypeBusinessRules companyTypeBusinessRules,
        IMapper mapper) : IRequestHandler<DeleteCompanyTypeCommand, DeletedCompanyTypeResponse>
    {
        public async Task<DeletedCompanyTypeResponse> Handle(DeleteCompanyTypeCommand request, CancellationToken cancellationToken)
        {
            await companyTypeBusinessRules.CompanyTypeIdShouldBeExist(request.Id);

            CompanyType companyType = await companyTypeRepository.GetAsync(x => x.Id == request.Id, cancellationToken: cancellationToken);

            if (companyType is null)
                throw new BusinessException("CompanyType does not exist.");

            await companyTypeRepository.DeleteAsync(companyType);

            DeletedCompanyTypeResponse response = mapper.Map<DeletedCompanyTypeResponse>(companyType);

            return response;
        }
    }
}
