using Core.Persistence.Repositories;
using Core.Security.Entities;
using CRM.Application.Repositories;
using CRM.Persistence.Contexts;

namespace CRM.Persistence.Repositories;

public class EmailAuthenticatorRepository : EfRepositoryBase<EmailAuthenticator, int, BaseDbContext>, IEmailAuthenticatorRepository
{
    public EmailAuthenticatorRepository(BaseDbContext context)
        : base(context) { }

    public async Task<EmailAuthenticator?> GetByUserIdAsync(int userId)
    {
        var emailAuth = await GetAsync(x => x.UserId == userId);

        return emailAuth;
    }
}
