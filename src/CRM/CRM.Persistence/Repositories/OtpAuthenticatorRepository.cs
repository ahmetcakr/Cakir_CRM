using Core.Persistence.Repositories;
using Core.Security.Entities;
using CRM.Application.Repositories;
using CRM.Persistence.Contexts;

namespace CRM.Persistence.Repositories;

public class OtpAuthenticatorRepository : EfRepositoryBase<OtpAuthenticator, int, BaseDbContext>, IOtpAuthenticatorRepository
{
    public OtpAuthenticatorRepository(BaseDbContext context)
        : base(context) { }
}
