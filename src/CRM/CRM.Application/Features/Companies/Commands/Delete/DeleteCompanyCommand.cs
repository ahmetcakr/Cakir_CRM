using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.CrossCuttingConcerns.Exceptions.Types;
using CRM.Application.Features.Companies.Commands.Delete;
using CRM.Application.Features.Companies.Constants;
using CRM.Application.Features.Companies.Rules;
using CRM.Application.Repositories;
using CRM.Domain.Entities;
using MediatR;
using static CRM.Application.Features.Companies.Constants.CompaniesOperationClaims;

namespace CRM.Application.Features.Companies.Commands.Delete;

public class DeleteCompanyCommand : IRequest<DeletedCompanyResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new[]
    {
        Admin,
        CompaniesOperationClaims.Delete,
        Write
    };

    public class DeleteCompanyCommandHandler(
        ICompanyRepository companyRepository,
        CompanyBusinessRules companyBusinessRules,
        IMapper mapper) : IRequestHandler<DeleteCompanyCommand, DeletedCompanyResponse>
    {
        public async Task<DeletedCompanyResponse> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            await companyBusinessRules.CompanyIdShouldBeExist(request.Id);

            Company company = await companyRepository.GetAsync(x => x.Id == request.Id, cancellationToken: cancellationToken);

            if (company is null)
                throw new BusinessException("Company does not exist.");

            await companyRepository.DeleteAsync(company);

            DeletedCompanyResponse response = mapper.Map<DeletedCompanyResponse>(company);

            return response;
        }
    }
}
