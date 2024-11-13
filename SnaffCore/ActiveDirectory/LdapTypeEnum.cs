﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnaffCore.ActiveDirectory.LDAP
{
    internal enum LdapTypeEnum
    {
        User,
        Computer,
        Group,
        GPO,
        Domain,
        OU,
        Unknown
    }
}