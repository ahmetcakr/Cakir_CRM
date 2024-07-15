﻿using AutoMapper;
using Core.Application.Pipelines.Authorization;
using CRM.Application.Features.Companies.Constants;
using CRM.Application.Features.Companies.Rules;
using CRM.Application.Repositories;
using CRM.Domain.Entities;
using MediatR;

namespace CRM.Application.Features.Companies.Commands.Create;

public class CreateCompanyCommand : IRequest<CreatedCompanyResponse>, ISecuredRequest
{
    public string CompanyName { get; set; }
    public int CompanyTypeId { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }


    public string[] Roles => new [] 
    {
        CompaniesOperationClaims.Admin,
        CompaniesOperationClaims.Write, 
        CompaniesOperationClaims.Add
    };

    public CreateCompanyCommand()
    {
        CompanyName = string.Empty;
        CompanyTypeId = 0;
        Address = string.Empty;
        Phone = string.Empty;
        Email = string.Empty;
        Website = string.Empty;
    }

    public CreateCompanyCommand(string companyName, int companyTypeId, string address, string phone, string email, string website)
    {
        CompanyName = companyName;
        CompanyTypeId = companyTypeId;
        Address = address;
        Phone = phone;
        Email = email;
        Website = website;
    }

    internal sealed class CreateCompanyCommandHandler
        (ICompanyRepository companyRepository,
        IMapper mapper,
        CompanyBusinessRules companyBusinessRules) : IRequestHandler<CreateCompanyCommand, CreatedCompanyResponse>
    {
        public async Task<CreatedCompanyResponse> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            Company company = mapper.Map<Company>(request);

            Company createdCompany = await companyRepository.AddAsync(company);

            CreatedCompanyResponse response = mapper.Map<CreatedCompanyResponse>(createdCompany);

            return response;
        }
    }
}
