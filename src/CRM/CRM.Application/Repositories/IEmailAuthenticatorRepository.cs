﻿using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace CRM.Application.Repositories;

public interface IEmailAuthenticatorRepository : IAsyncRepository<EmailAuthenticator, int>, IRepository<EmailAuthenticator, int> 
{
    // GetByUserIdAsync
    Task<EmailAuthenticator?> GetByUserIdAsync(int userId);

}
