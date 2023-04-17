using MyCleanArchTemplate.Application;
using MyCleanArchTemplate.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

@*#if (EnableSwaggerSupport)
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endif*@
builder.Services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
@*#if (EnableSwaggerSupport)

    app.UseSwagger();
    app.UseSwaggerUI();
#endif*@
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
