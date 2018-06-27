﻿using Volo.Abp.Users;

namespace Volo.Abp.Identity
{
    public static class IdentityUserConsts
    {
        public const int MaxUserNameLength = AbpUserConsts.MaxUserNameLength;

        public const int MaxNormalizedUserNameLength = MaxUserNameLength;

        public const int MaxEmailLength = AbpUserConsts.MaxEmailLength;

        public const int MaxNormalizedEmailLength = MaxEmailLength;

        public const int MaxPhoneNumberLength = AbpUserConsts.MaxPhoneNumberLength;

        public const int MaxPasswordLength = 32;

        public const int MaxPasswordHashLength = 256;

        public const int MaxSecurityStampLength = 256;

        public const int MaxConcurrencyStampLength = 256;
    }
}