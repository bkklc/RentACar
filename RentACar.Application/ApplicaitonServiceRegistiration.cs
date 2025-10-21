using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RentACar.Application
{
    public static class ApplicaitonServiceRegistiration
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());

            });


            return services;
        }
    }
}
