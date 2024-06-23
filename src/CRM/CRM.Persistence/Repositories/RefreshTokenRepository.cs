using Core.Persistence.Repositories;
using Core.Security.Entities;
using CRM.Application.Repositories;
using CRM.Persistence.Contexts;

namespace CRM.Persistence.Repositories;

public class RefreshTokenRepository : EfRepositoryBase<RefreshToken, int, BaseDbContext>, IRefreshTokenRepository
{
    public RefreshTokenRepository(BaseDbContext context)
        : base(context) { }
}
