using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace DxBlazorApplicationScheduler.Services
{
    public class RoleToClaimsTransformer : IClaimsTransformation
    {
        public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            var identity = (ClaimsIdentity)principal.Identity!;

            if (!identity.IsAuthenticated)
                return Task.FromResult(principal);

            // Avoid duplicate claims if already set
            if (identity.HasClaim(c => c.Type == "CanCreateAppointment"))
                return Task.FromResult(principal);

            // Map roles to claims
            if (identity.HasClaim(ClaimTypes.Role, "Administratoren"))
            {
                identity.AddClaim(new Claim("CanCreateAppointment", "true"));
                identity.AddClaim(new Claim("CanEditAppointment", "true"));
                identity.AddClaim(new Claim("CanDeleteAppointment", "true"));
            }
            else if (identity.HasClaim(ClaimTypes.Role, "Editor"))
            {
                identity.AddClaim(new Claim("CanCreateAppointment", "false"));
                identity.AddClaim(new Claim("CanEditAppointment", "true"));
                identity.AddClaim(new Claim("CanDeleteAppointment", "false"));
            }
            else if (identity.HasClaim(ClaimTypes.Role, "Viewer"))
            {
                identity.AddClaim(new Claim("CanCreateAppointment", "false"));
                identity.AddClaim(new Claim("CanEditAppointment", "false"));
                identity.AddClaim(new Claim("CanDeleteAppointment", "false"));
            }

            return Task.FromResult(principal);
        }
    }

}
