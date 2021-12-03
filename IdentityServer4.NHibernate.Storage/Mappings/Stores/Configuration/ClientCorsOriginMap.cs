using IdentityServer4.NHibernate.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace IdentityServer4.NHibernate.Mappings.Stores.Configuration
{
    internal class ClientCorsOriginMap : ClassMapping<ClientCorsOrigin>
    {
        public ClientCorsOriginMap()
        {
            Table("openid_client_cors");

            Id(p => p.ID);

            Property(p => p.Origin, map =>
            {
                map.Length(150);
                map.NotNullable(true);
            });
        }
    }
}
