﻿using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.CrossCuttingConcerns.Exceptions.Types;
using CRM.Application.Features.CompanyTypes.Commands.Update;
using CRM.Application.Features.CompanyTypes.Constants;
using CRM.Application.Features.CompanyTypes.Rules;
using CRM.Application.Repositories;
using MediatR;

namespace CRM.Application.Features.CompanyTypes.Commands.Update;

public class UpdateCompanyTypeCommand : IRequest<UpdatedCompanyTypeResponse>, ISecuredRequest
{
    public int Id { get; set; }
    public string TypeName { get; set; }
    public string Description { get; set; }

    public string[] Roles => new[]
    {
        CompanyTypesOperationClaims.Admin,
        CompanyTypesOperationClaims.Write,
        CompanyTypesOperationClaims.Update
    };

    public UpdateCompanyTypeCommand()
    {
        Id = 0;
        TypeName = string.Empty;
        Description = string.Empty;
    }

    public UpdateCompanyTypeCommand(int id, string typeName, string description)
    {
        Id = id;
        TypeName = typeName;
        Description = description;
    }

    internal sealed class UpdateCompanyTypeCommandHandler(
        ICompanyTypeRepository companyTypeRepository,
        IMapper mapper,
        CompanyTypeBusinessRules companyTypeBusinessRules) : IRequestHandler<UpdateCompanyTypeCommand, UpdatedCompanyTypeResponse>
    {
        public async Task<UpdatedCompanyTypeResponse> Handle(UpdateCompanyTypeCommand request, CancellationToken cancellationToken)
        {
            await companyTypeBusinessRules.CompanyTypeIdShouldBeExist(request.Id);

            var companyType = await companyTypeRepository.GetAsync(x => x.Id == request.Id, cancellationToken: cancellationToken);

            if (companyType is null)
                throw new BusinessException("Company does not exist.");

            mapper.Map(request, companyType);

            var updatedCompanyType = await companyTypeRepository.UpdateAsync(companyType);

            UpdatedCompanyTypeResponse response = mapper.Map<UpdatedCompanyTypeResponse>(updatedCompanyType);

            return response;
        }
    }
}
