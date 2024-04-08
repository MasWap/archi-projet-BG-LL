using GestionHotel.Apis;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Ajoutez cette ligne pour enregistrer les contrôleurs
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
	c.SwaggerDoc("v1", new OpenApiInfo { Title = "GestionHotel API", Version = "v1" });
});

// Spécifier les URL d'écoute
builder.WebHost.UseUrls("http://+:80");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI(c =>
	{
		c.SwaggerEndpoint("/swagger/v1/swagger.json", "GestionHotel API V1");
	});
}

// app.UseHttpsRedirection(); // Commenter pour supprimer la redirection HTTPS

app.UseRouting(); // Ajoutez cette ligne pour activer le routage
app.UseAuthorization(); // Ajoutez cette ligne pour activer l'autorisation
app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers(); // Ajoutez cette ligne pour mapper les contrôleurs
});

app.Run();