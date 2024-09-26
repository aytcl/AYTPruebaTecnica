using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using PruebaTecnica.Endpoints;
using PruebaTecnica.Interfaces;
using PruebaTecnica.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiVersioning();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ISmartphoneService, SmartphoneService>();

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.PropertyNameCaseInsensitive = true;
    options.SerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapSmartphoneEndpoint();
// app.UseHttpsRedirection();
app.Run();
