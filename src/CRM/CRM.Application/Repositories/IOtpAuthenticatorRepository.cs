﻿using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace CRM.Application.Repositories;

public interface IOtpAuthenticatorRepository : IAsyncRepository<OtpAuthenticator, int>, IRepository<OtpAuthenticator, int> { }
