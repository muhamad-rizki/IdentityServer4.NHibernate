using IdentityServer4.NHibernate.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace IdentityServer4.NHibernate.Mappings.Stores.Configuration
{
    internal class ClientIdPRestrictionMap : ClassMapping<ClientIdPRestriction>
    {
        public ClientIdPRestrictionMap()
        {
            Table("openid_client_idp_restriction");

            Id(p => p.ID);

            Property(p => p.Provider, map =>
            {
                map.Length(200);
                map.NotNullable(true);
            });
        }
    }
}
