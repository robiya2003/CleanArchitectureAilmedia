using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure
{
    public static class DependencyInjectionInfastruture
    {
        public static IServiceCollection AddInfastuctureServiose(this IServiceCollection services,
            IConfiguration configuration)
        {
            
            return services;
        }
    }
}
