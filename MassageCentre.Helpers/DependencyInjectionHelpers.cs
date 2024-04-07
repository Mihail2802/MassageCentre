using MassageCentre.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace MassageCentre.Helpers
{
    public static class DependencyInjectionHelpers
    {
        public static IServiceCollection InjectDbContext(this IServiceCollection services, string connectionString) 
        {
            services.AddDbContext<MassageCentreDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
