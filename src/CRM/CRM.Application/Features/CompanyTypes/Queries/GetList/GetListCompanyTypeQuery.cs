﻿using AutoMapper;
using Core.Application.Pipelines.Caching;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using CRM.Application.Repositories;
using CRM.Domain.Entities;
using MediatR;

namespace CRM.Application.Features.CompanyTypes.Queries.GetList;

public class GetListCompanyTypeQuery : IRequest<GetListResponse<GetListCompanyTypeResponse>>, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public bool BypassCache {get;}

    public string CacheKey => $"GetListCompanyTypes({PageRequest.PageIndex},{PageRequest.PageSize})";

    public string? CacheGroupKey => "GetCompanyTypes";

    public TimeSpan? SlidingExpiration { get; }

    public GetListCompanyTypeQuery()
    {
        PageRequest = new PageRequest { PageIndex = 0, PageSize = 10 };
    }

    public GetListCompanyTypeQuery(PageRequest pageRequest)
    {
        PageRequest = pageRequest;
    }

    public GetListCompanyTypeQuery(PageRequest pageRequest, bool bypassCache, TimeSpan? slidingExpiration)
    {
        PageRequest = pageRequest;
        BypassCache = bypassCache;
        SlidingExpiration = slidingExpiration;
    }

    internal sealed class GetListCompanyTypeQueryHandler(
        ICompanyTypeRepository companyTypeRepository,
        IMapper mapper) : IRequestHandler<GetListCompanyTypeQuery, GetListResponse<GetListCompanyTypeResponse>>
    {
        public async Task<GetListResponse<GetListCompanyTypeResponse>> Handle(GetListCompanyTypeQuery request, CancellationToken cancellationToken)
        {
            IPaginate<CompanyType> companyTypes = await companyTypeRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListCompanyTypeResponse> response = mapper.Map<GetListResponse<GetListCompanyTypeResponse>>(companyTypes);

            return response;
        }
    }

}
