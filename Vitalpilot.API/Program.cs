using Vitalpilot.Domain.Helper;
using Vitalpilot.Domain.Mappings;
using Vitalpilot.EntityFramework;
using Vitalpilot.Services;
using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
ApplicationSettings appSettings = new ApplicationSettings();
configuration.Bind(appSettings);

// Add services to the container.
builder.Services.AddVitalpilotEntityFramework(builder.Configuration);
builder.Services.AddVitalpilotServices();

builder.Services.AddAutoMapper(typeof(MappingProfiles));

builder.Services.AddFluentValidationAutoValidation()
    .AddFluentValidationClientsideAdapters();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.Run();