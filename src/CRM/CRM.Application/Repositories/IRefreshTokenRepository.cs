using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace CRM.Application.Repositories
{
    public interface IRefreshTokenRepository : IAsyncRepository<RefreshToken, int>, IRepository<RefreshToken, int> { }
}
