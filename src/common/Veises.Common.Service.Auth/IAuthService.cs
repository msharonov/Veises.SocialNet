﻿using JetBrains.Annotations;

namespace Veises.Common.Service.Auth
{
    public interface IAuthService
    {
        [NotNull]
        AuthSession Authorize([NotNull] UserAuthData userAuthData);
    }
}