using Microsoft.Extensions.DependencyInjection;
using OrderCustomer_Managment.Application.Common.Interfaces;
using OrderCustomer_Managment.Infrastructure.Repository;

namespace OrderCustomer_Managment.Infrastructure.DependencyInjections;

public static class DependencyInjection 
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IOrderInterface, OrderRepository>();
        services.AddScoped<ICustomerInterface, CustomerRepository>();

        return services;
    }
}