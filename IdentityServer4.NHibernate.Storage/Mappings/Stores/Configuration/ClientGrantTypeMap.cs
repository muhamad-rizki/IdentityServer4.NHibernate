﻿using IdentityServer4.NHibernate.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace IdentityServer4.NHibernate.Mappings.Stores.Configuration
{
    internal class ClientGrantTypeMap : ClassMapping<ClientGrantType>
    {
        public ClientGrantTypeMap()
        {
            Table("openid_client_grant_type");

            Id(p => p.ID);

            Property(p => p.GrantType, map => 
            {
                map.Length(250);
                map.NotNullable(true);
            });
        }
    }
}
