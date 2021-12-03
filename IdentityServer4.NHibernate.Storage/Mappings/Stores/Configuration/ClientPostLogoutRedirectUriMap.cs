using IdentityServer4.NHibernate.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace IdentityServer4.NHibernate.Mappings.Stores.Configuration
{ 
    internal class ClientPostLogoutRedirectUriMap : ClassMapping<ClientPostLogoutRedirectUri>
    {
        public ClientPostLogoutRedirectUriMap()
        {
            Table("openid_client_post_logout_redirect_uri");

            Id(p => p.ID);

            Property(p => p.PostLogoutRedirectUri, map => 
            {
                map.Length(2000);
                map.NotNullable(true);
            });
        }
    }
}
