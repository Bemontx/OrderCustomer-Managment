using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection; 
using OrderCustomer_Managment.Application.Common.Interfaces;
using OrderCustomer_Managment.Infrastructure.Persistence;
using OrderCustomer_Managment.Infrastructure.Repository;

namespace OrderCustomer_Managment.Infrastructure.DependencyInjections;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Configuración de EF Core
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection")));

        // Registro de Repositories
        services.AddScoped<ICustomerInterface, CustomerRepository>();
        services.AddScoped<IOrderInterface, OrderRepository>();

        return services;
    }
}
