﻿using IdentityServer4.NHibernate.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace IdentityServer4.NHibernate.Mappings.Stores.Configuration
{
    internal class ApiResourceClaimMap : ClassMapping<ApiResourceClaim>
    {
        public ApiResourceClaimMap()
        {
            Table("openid_api_resource_claim");

            Id(p => p.ID);

            Property(p => p.Type, map => 
            {
                map.Length(200);
                map.NotNullable(true);
            });
        }
    }
}
