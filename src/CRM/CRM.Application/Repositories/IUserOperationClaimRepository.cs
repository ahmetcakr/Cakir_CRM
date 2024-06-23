using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace CRM.Application.Repositories;

public interface IUserOperationClaimRepository : IAsyncRepository<UserOperationClaim, int>, IRepository<UserOperationClaim, int> { }
