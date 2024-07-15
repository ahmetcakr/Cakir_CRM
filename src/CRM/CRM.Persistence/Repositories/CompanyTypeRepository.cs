using Core.Persistence.Repositories;
using CRM.Application.Repositories;
using CRM.Domain.Entities;
using CRM.Persistence.Contexts;

namespace CRM.Persistence.Repositories;

public class CompanyTypeRepository : EfRepositoryBase<CompanyType,
    int, BaseDbContext>, ICompanyTypeRepository
{
    public CompanyTypeRepository(BaseDbContext context) 
        : base(context) { }
}
