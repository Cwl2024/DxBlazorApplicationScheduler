using DxBlazorApplicationScheduler.Components;
using DxBlazorApplicationScheduler.Services;
using DxBlazorApplicationScheduler.Client.Pages;
using DxBlazorApplicationScheduler.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication.Cookies;
using DxBlazorApplicationScheduler.Login;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Authentication;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
    //.AddInteractiveWebAssemblyComponents()


builder.Services.AddDevExpressBlazor(options =>
{
    options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
    options.SizeMode = DevExpress.Blazor.SizeMode.Medium;
});







builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
     // Configure cookie settings
        options.Cookie.Name = "auth_token";
        options.LoginPath = "/login";
        options.LogoutPath = "/logout";
        options.AccessDeniedPath = "/accessdenied";
        options.ReturnUrlParameter = "returnUrl";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
        options.SlidingExpiration = true;
        options.Cookie.IsEssential = true;
        options.Cookie.HttpOnly = true;
    });
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireAuthenticatedUser", policy => policy.RequireAuthenticatedUser());
    options.AddPolicy("RequireAdministratorRole", policy => policy.RequireRole("Administratoren"));

    //options.AddPolicy("CanCreateAppointments", policy => policy.RequireRole("Administratoren"));
    //options.AddPolicy("CanEditAppointments", policy => policy.RequireRole("Administratoren"));
    //options.AddPolicy("CanDeleteAppointments", policy => policy.RequireRole("Administratoren"));
});
builder.Services.AddScoped<IClaimsTransformation, RoleToClaimsTransformer>();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<UserAccountService>();
builder.Services.AddScoped<AuthenticationStateProvider, AuthenticationStateValidator>();
builder.Services.AddScoped<LoginState>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient();

builder.Services.AddDataProtection()
    .PersistKeysToFileSystem(new DirectoryInfo(@"C:\keys"))
    .SetApplicationName("DxBlazorApplicationScheduler");




builder.Services.AddMvc();

builder.Services.AddDbContextFactory<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
builder.Services.AddScoped(sp =>
    sp.GetRequiredService<IOptions<EmailSettings>>().Value);

// Scoped lifetime for access to DbContext (if not necessary then transient)
builder.Services.AddScoped<EmailService>();













var app = builder.Build();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
    //.AddInteractiveWebAssemblyRenderMode()
    //.AddAdditionalAssemblies(typeof(Counter).Assembly);

app.MapControllers();


app.Run();