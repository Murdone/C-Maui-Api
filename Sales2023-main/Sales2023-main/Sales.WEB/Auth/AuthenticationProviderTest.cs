using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Sales.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public async override  Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            
            var anonimous = new ClaimsIdentity();
            var PerciUser = new ClaimsIdentity(new List<Claim>
            {
            new Claim("FirstName", "Percibal"),
            new Claim("LastName", "Vasquez"),
            new Claim(ClaimTypes.Name, "vasquez.percibal@gmail.com"),
            new Claim(ClaimTypes.Role, "Admin")
            },
            authenticationType: "test");

            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(PerciUser)));
        }
    }

}
