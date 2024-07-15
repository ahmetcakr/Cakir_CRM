using Core.Persistence.Paging;
using CRM.Application.Features.CompanyTypes.Rules;
using CRM.Application.Repositories;
using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace CRM.Application.Services.CompaniesService;

public class CompanyTypeManager(
    ICompanyTypeRepository companyTypeRepository,
    CompanyTypeBusinessRules companyTypeBusinessRules) : ICompanyTypeService
{
    public async Task<CompanyType> AddAsync(CompanyType companyType)
    {
        await companyTypeBusinessRules.CompanyTypeNameShouldNotExistsWhenInsert(companyType.TypeName);

        return await companyTypeRepository.AddAsync(companyType);
    }

    public async Task<CompanyType> DeleteAsync(CompanyType companyType, bool permanent = false)
    {
        return await companyTypeRepository.DeleteAsync(companyType, permanent);
    }

    public async Task<CompanyType?> GetAsync(Expression<Func<CompanyType, bool>> predicate, Func<IQueryable<CompanyType>, IIncludableQueryable<CompanyType, object>>? include = null, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
    {
        var companyTypes = await companyTypeRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return companyTypes;
    }

    public async Task<IPaginate<CompanyType?>?> GetListAsync(Expression<Func<CompanyType, bool>>? predicate = null, Func<IQueryable<CompanyType>, IOrderedQueryable<CompanyType>>? orderBy = null, Func<IQueryable<CompanyType>, IIncludableQueryable<CompanyType, object>>? include = null, int index = 0, int size = 10, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
    {
        IPaginate<CompanyType> companyTypeList = await companyTypeRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );

        return companyTypeList;
    }

    public async Task<CompanyType> UpdateAsync(CompanyType request)
    {
        CompanyType companyType = await companyTypeRepository.UpdateAsync(request);
        return companyType;
    }
}
