using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Karyakraam.Application;

public static class DependencyInjection
{
 public static IServiceCollection AddApplicationServices(
  this IServiceCollection services, IConfiguration configuration)
 {
  // services.AddScoped<ITokenService, TokenService>();
  // ... other registrations
  return services;
 }
}