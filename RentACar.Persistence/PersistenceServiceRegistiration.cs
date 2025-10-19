using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentACar.Application.Repositories;
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
                                                                 configuration.GetConnectionString("DefaultConnection")));

            
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<ICampaignRepository, CampaignRepository>();
            services.AddScoped<ICapacityRepository, CapacityRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IDoorRepository, DoorRepository>();
            services.AddScoped<IFuelTypeRepository, FuelTypeRepository>();
            services.AddScoped<IGearRepository, GearRepository>();
            services.AddScoped<IModelRepository, ModelRepository>();
            services.AddScoped<IRentalRepository, RentalRepository>();
            services.AddScoped<ISerieRepository, SerieRepository>();
            services.AddScoped<IUserAddressRepository, UserAddressRepository>();
            services.AddScoped<IWheelDriveRepository, WheelDriveRepository>();
            services.AddScoped<IYearRepository, YearRepository>();

            return services;
        }
    }
}
