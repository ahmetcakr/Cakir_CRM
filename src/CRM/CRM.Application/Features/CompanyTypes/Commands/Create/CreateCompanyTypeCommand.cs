﻿using AutoMapper;
using Core.Application.Pipelines.Authorization;
using CRM.Application.Features.CompanyTypes.Constants;
using CRM.Application.Features.CompanyTypes.Rules;
using CRM.Application.Repositories;
using CRM.Domain.Entities;
using MediatR;

namespace CRM.Application.Features.CompanyTypes.Commands.Create;

public class CreateCompanyTypeCommand : IRequest<CreatedCompanyTypeResponse>, ISecuredRequest
{
    public string TypeName { get; set; }
    public string Description { get; set; }


    public string[] Roles => new [] 
    {
        CompanyTypesOperationClaims.Admin,
        CompanyTypesOperationClaims.Write,
        CompanyTypesOperationClaims.Add
    };

    public CreateCompanyTypeCommand()
    {
        TypeName = string.Empty;
        Description = string.Empty;
    }

    public CreateCompanyTypeCommand(string typeName, string description)
    {
        TypeName = typeName;
        Description = description;
    }

    internal sealed class CreateCompanyTypeCommandHandler
        (ICompanyTypeRepository companyTypeRepository,
        IMapper mapper,
        CompanyTypeBusinessRules companyTypeBusinessRules) : IRequestHandler<CreateCompanyTypeCommand, CreatedCompanyTypeResponse>
    {
        public async Task<CreatedCompanyTypeResponse> Handle(CreateCompanyTypeCommand request, CancellationToken cancellationToken)
        {
            CompanyType companyType = mapper.Map<CompanyType>(request);

            CompanyType createdCompanyType = await companyTypeRepository.AddAsync(companyType);

            CreatedCompanyTypeResponse response = mapper.Map<CreatedCompanyTypeResponse>(createdCompanyType);

            return response;
        }
    }
}
