using System.Runtime.Intrinsics.Arm;
using Duende.IdentityServer.Models;

namespace IdentityService;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
            new ApiScope("auctionApp","Auction app full access"),
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
            new Client
            {
                ClientId = "postman",
                ClientName = "Postman",
                //ClientSecrets = {new Secret(config["ClientSecret"].Sha256())},
                AllowedGrantTypes = {GrantType.ResourceOwnerPassword},
               // RequirePkce = false,
                RedirectUris = { "/api/auth/callback/id-server"},
               // AllowOfflineAccess = true,
                AllowedScopes = {"openid", "profile", "auctionApp"},
                ClientSecrets = new[] {new Secret ("NotASecret".Sha256())}
             //   AccessTokenLifetime = 3600*24*30,
               // AlwaysIncludeUserClaimsInIdToken = true
            }
        };
}
