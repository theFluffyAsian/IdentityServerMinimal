using System.Collections.Generic;
using IdentityModel;
using IdentityServer4.Models;

namespace IdentityServer
{
    public static class Configuration
    {
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new ApiScope[]
            {
                new ApiScope("AzureFunction.ProductStatus"),
                //new ApiScope("WebPortal.Everything")
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new ApiResource[]
            {
                new ApiResource
                {
                    Name = "AzureFunction",
                    Scopes = new List<string> { "AzureFunction.ProductStatus" },
                },
                //new ApiResource
                //{
                //    Name = "WebPortal",
                //    Scopes = new List<string> { "WebPortal.Everything" },
                //}
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "FmeServer",
                    ClientSecrets = { new Secret("client_secret".ToSha256()) },
                    
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "AzureFunction.ProductStatus" }
                },
                //new Client
                //{
                //    ClientId = "WebPortal",
                //    ClientSecrets = { new Secret("Webportal_Secret".ToSha256()) },
                    
                //    AllowedGrantTypes = GrantTypes.Code,
                //    AllowedScopes =
                //    {
                //        "WebPortal.Everything",
                        
                //    }
                //}
            };
        }
    }
}