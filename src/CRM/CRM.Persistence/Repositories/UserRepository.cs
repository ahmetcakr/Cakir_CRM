using Core.Persistence.Repositories;
using Core.Security.Entities;
using CRM.Application.Repositories;
using CRM.Persistence.Contexts;

namespace CRM.Persistence.Repositories;

public class UserRepository : EfRepositoryBase<User, int, BaseDbContext>, IUserRepository
{
    public UserRepository(BaseDbContext context)
        : base(context) { }
}
