using Jwt.Authentication.Study.Api.Configuration.DependencyInjection;
using Jwt.Authentication.Study.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.RegisterApplication(builder.Configuration);

//This method allows services to get an instance of HttpContext
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseMiddleware<JwtMiddleware>();

app.MapControllers();

app.Run();
