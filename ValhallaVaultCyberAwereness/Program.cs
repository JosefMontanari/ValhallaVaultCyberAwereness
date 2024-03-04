using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Components;
using ValhallaVaultCyberAwereness.Components.Account;
using ValhallaVaultCyberAwereness.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
	{
		options.DefaultScheme = IdentityConstants.ApplicationScheme;
		options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
	})
	.AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
	.AddRoles<IdentityRole>()
	.AddEntityFrameworkStores<ApplicationDbContext>()
	.AddSignInManager()
	.AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
using (ServiceProvider sp = builder.Services.BuildServiceProvider())
{
	var context = sp.GetRequiredService<ApplicationDbContext>();
	var signInManager = sp.GetRequiredService<SignInManager<ApplicationUser>>();
	var roleManager = sp.GetRequiredService<RoleManager<IdentityRole>>();

	// Kolla om det finns en databas
	context.Database.Migrate();

	ApplicationUser newUser = new()
	{
		UserName = "admin",
		Email = "adminUser@mail.com",
		EmailConfirmed = true

	};

	var user = signInManager.UserManager.FindByEmailAsync(newUser.Email)
		/*K�r Metoden synkront! Viktigt!*/
		.GetAwaiter().GetResult();

	if (user == null)
	{
		// Skapa ny user
		signInManager.UserManager.CreateAsync(newUser, "Password1234!")
			// K�r metoden Synkront! Viktigt!
			.GetAwaiter().GetResult();

		// Kolla om adminrollen existerar
		bool adminRoleExists = roleManager.RoleExistsAsync("Admin")
			// K�r metoden Synkront! Viktigt!
			.GetAwaiter().GetResult();
		if (!adminRoleExists)
		{
			// Skapa adminrollen
			IdentityRole adminRole = new()
			{
				Name = "Admin",
			};

			roleManager.CreateAsync(adminRole)
				// K�r metoden Synkront! Viktigt!
				.GetAwaiter().GetResult();
		}
		// Tilldela adminrollen till den nya anv�ndaren
		signInManager.UserManager.AddToRoleAsync(newUser, "Admin")
			// K�r metoden Synkront! Viktigt!
			.GetAwaiter().GetResult();
	}
}
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseMigrationsEndPoint();
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

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();
