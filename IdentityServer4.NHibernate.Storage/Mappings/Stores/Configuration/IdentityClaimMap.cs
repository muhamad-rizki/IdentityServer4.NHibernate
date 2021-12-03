using IdentityServer4.NHibernate.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace IdentityServer4.NHibernate.Mappings.Stores.Configuration
{
    internal class IdentityClaimMap : ClassMapping<IdentityClaim>
    {
        public IdentityClaimMap()
        {
            Table("openid_identity_client");

            Id(p => p.ID);

            Property(p => p.Type, map => 
            {
                map.Length(200);
                map.NotNullable(true);
            });
        }
    }
}
