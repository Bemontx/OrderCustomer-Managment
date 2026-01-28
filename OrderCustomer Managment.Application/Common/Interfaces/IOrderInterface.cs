using MediatR;
using OrderCustomer_Managment.Domain.Entities;

namespace OrderCustomer_Managment.Application.Common.Interfaces;

public interface IOrderInterface
{
    Task AddAsync(Order order);
    Task UpdateAsync(Order order);
    Task DeleteAsync(Guid id);
    Task<Order?> GetByIdAsync(Guid id);
    Task<IEnumerable<Order>> GetAllAsync();

}
