namespace DxBlazorApplicationScheduler.Login
{

    using System;
    using System.Security.Claims;
    using Microsoft.AspNetCore.Components.Authorization;
    using Microsoft.AspNetCore.Components.Server;

    public class AuthenticationStateValidator
        : RevalidatingServerAuthenticationStateProvider
    {
        protected override TimeSpan RevalidationInterval => TimeSpan.FromSeconds(10);

        private LoginState _loginState;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthenticationStateValidator(ILoggerFactory loggerFactory, LoginState loginState, IHttpContextAccessor httpContextAccessor)
          : base(loggerFactory)
        {
            _loginState = loginState;
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        protected override Task<bool> ValidateAuthenticationStateAsync(AuthenticationState authenticationState, CancellationToken cancellationToken)
        {
            //var id =
            //    authenticationState.User.Claims
            //    .Where(c => c.Type.Equals("sid"))
            //    .Select(c => c.Value)
            //    .FirstOrDefault();

            var id = authenticationState.User.Identity.Name;

            return Task.FromResult(_loginState.IsUserLoggedIn(id ?? ""));
        }


        // Dont think the following method is needed, for manual use only, but it should work automatically anyway

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var user = _httpContextAccessor.HttpContext?.User
                       ?? new ClaimsPrincipal(new ClaimsIdentity());
            return Task.FromResult(new AuthenticationState(user));
        }
    }

}
