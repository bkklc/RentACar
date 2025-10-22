using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentACar.Application.Interfaces.Repositories;
using RentACar.Persistence.Context;
using RentACar.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;


namespace RentACar.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddDbContext<RentACarDbContext>(options =>
                                                             options.UseSqlServer(
                                                                 configuration.GetConnectionString("RentACar")));

            
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IBodyTypeRepository, BodyTypeRepository>();
            services.AddScoped<ICampaignRepository, CampaignRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IDoorTypeRepository, DoorTypeRepository>();
            services.AddScoped<IFuelTypeRepository, FuelTypeRepository>();
            services.AddScoped<IGearTypeRepository, GearTypeRepository>();
            services.AddScoped<IModelRepository, ModelRepository>();
            services.AddScoped<IModelYearRepository, ModelYearRepository>();
            services.AddScoped<IRentalRepository, RentalRepository>();
            services.AddScoped<ISeatCapacityRepository, SeatCapacityRepository>();
            services.AddScoped<ISerieRepository, SerieRepository>();
            services.AddScoped<ICustomerAddressRepository, CustomerAddressRepository>();
            services.AddScoped<IWheelDriveTypeRepository, WheelDriveTypeRepository>();

            return services;
        }
    }
}
