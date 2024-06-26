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

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins("http://localhost:4200")
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();