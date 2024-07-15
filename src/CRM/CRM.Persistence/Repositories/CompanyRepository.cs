using Core.Persistence.Repositories;
using CRM.Application.Repositories;
using CRM.Domain.Entities;
using CRM.Persistence.Contexts;

namespace CRM.Persistence.Repositories;

public class CompanyRepository : EfRepositoryBase<Company,
    int, BaseDbContext>, ICompanyRepository
{
    public CompanyRepository(BaseDbContext context) 
        : base(context) { }
}
