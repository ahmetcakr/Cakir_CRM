﻿using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace CRM.Application.Repositories;

public interface IUserRepository : IAsyncRepository<User, int>, IRepository<User, int> { }
