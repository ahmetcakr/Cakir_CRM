﻿using Core.Persistence.Repositories;
using Core.Security.Entities;
using CRM.Application.Repositories;
using CRM.Persistence.Contexts;

namespace CRM.Persistence.Repositories;

public class UserOperationClaimRepository : EfRepositoryBase<UserOperationClaim, int, BaseDbContext>, IUserOperationClaimRepository
{
    public UserOperationClaimRepository(BaseDbContext context)
        : base(context) { }
}

