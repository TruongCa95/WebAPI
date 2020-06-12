using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Data;

namespace WebAPI.Domain.Configuration
{
    public class Config
    {
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
        {
            new Client
            {
                ClientId = "XamarinRss",
                ClientName = "Xamarin Rss Demo",

                AllowedGrantTypes = GrantTypes.Implicit,

                RedirectUris = { "http://localhost:5001/signin-oidc" },
                PostLogoutRedirectUris = { "http://localhost:5001/signout-callback-oidc" },

                AllowedScopes =
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile
                }
            }
        };
        }

        //internal static List<User> GetUsers()
        //{
        //    return new List<User> {
        //    new User
        //    {
        //        SubjectId = "1",
        //        Username = "juergen@gutsch-online.de",
        //        Claims = new []{ new Claim("name", "Juergen Gutsch") },
        //        Password ="Hello01!"
        //    }
        //};
        //}

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
        {
            new ApiResource("reactchat", "React Chat Demo")
        };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
        };
        }
    }
}
