using Core.Persistence.Repositories;
using CRM.Domain.Entities;

namespace CRM.Application.Repositories;

public interface ICompanyTypeRepository : IAsyncRepository<CompanyType, int>, IRepository<CompanyType, int> { }
