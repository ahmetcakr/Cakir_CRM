﻿using AutoMapper;
using CRM.Application.Features.CompanyTypes.Rules;
using CRM.Application.Repositories;
using MediatR;

namespace CRM.Application.Features.CompanyTypes.Queries.GetById;

public class GetByIdCompanyTypeQuery : IRequest<GetByIdCompanyTypeResponse>
{
    public int Id { get; set; }

    internal sealed class GetByIdCompanyTypeQueryHandler(
        ICompanyTypeRepository companyTypeRepository,
        IMapper mapper,
        CompanyTypeBusinessRules companyTypeBusinessRules) : IRequestHandler<GetByIdCompanyTypeQuery, GetByIdCompanyTypeResponse>
    {

        public async Task<GetByIdCompanyTypeResponse> Handle(GetByIdCompanyTypeQuery request, CancellationToken cancellationToken)
        {
            var company = await companyTypeRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            GetByIdCompanyTypeResponse getByIdCompanyTypeResponse = mapper.Map<GetByIdCompanyTypeResponse>(company);

            return getByIdCompanyTypeResponse;
        }
    }
}
