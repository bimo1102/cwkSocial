using CwkSocial.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CwkSocial.Infrastructure
{
    public static class StartUpApplication
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<CwkSocialContext>(options => options.UseSqlServer("Data Source=LAMMOI;Initial Catalog=CwkSocial;User ID=sa;Password=1;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"));
            return services;
        }
    }
}
