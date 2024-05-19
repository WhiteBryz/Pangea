using Microsoft.EntityFrameworkCore;
// using Pangea.Client.Pages;
using Pangea.Components;
using Pangea.Model;
using Pangea.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PangeaDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IRepositoryOwners, RepositoryOwners>(); // Owners
builder.Services.AddScoped<IRepositoryIncomeConcept,RepositoryIncomeConcept>(); // IncomeConcepts
builder.Services.AddScoped<IRepositoryUserAdmin, RepositoryUserAdmin>(); // UserAdmin
builder.Services.AddScoped<IRepositoryIncome, RepositoryIncome>(); // Income
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents()
	.AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
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
	.AddInteractiveServerRenderMode()
	.AddInteractiveWebAssemblyRenderMode()
	.AddAdditionalAssemblies(typeof(Pangea.Client._Imports).Assembly);

app.Run();
