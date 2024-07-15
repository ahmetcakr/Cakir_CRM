using Core.Persistence.Repositories;
using CRM.Domain.Entities;

namespace CRM.Application.Repositories;

public interface ICompanyRepository : IAsyncRepository<Company, int>, IRepository<Company, int> { }
