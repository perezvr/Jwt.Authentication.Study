using Jwt.Authentication.Study.Api.Configuration.DependencyInjection;
using Jwt.Authentication.Study.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.RegisterApplication(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseMiddleware<JwtMiddleware>();

app.MapControllers();

app.Run();
