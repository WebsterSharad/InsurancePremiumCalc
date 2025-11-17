using InsurancePremiumCalc.Application.Interfaces;
using InsurancePremiumCalc.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePremiumCalc.Application
{
    public static class ApplicationLayerDependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
           
            services.AddScoped<IPremiumService, PremiumService>();

            return services;
        }
    }
}
