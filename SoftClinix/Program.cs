using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using SoftClinix.Data; // Asegúrate de que este namespace es correcto
using SoftClinix.Services;

var builder = WebApplication.CreateBuilder(args);
// Configurar la cadena de conexión
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Registrar ApplicationDbContext con MySQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Registrar el servicio PacienteService
builder.Services.AddScoped<PacienteService>();

// Agregar servicios de Razor Pages y Blazor Server
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
