using GestionHotel.Apis;
using GestionHotel.Apis.Endpoints.Booking;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<SampleInjectionInterface, SampleInjectionImplementation>();

// Spécifier les URL d'écoute
builder.WebHost.UseUrls("http://+:80");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection(); // Commenter pour supprimer la redirection HTTPS

app.MapBookingsEndpoints();
app.Run();
