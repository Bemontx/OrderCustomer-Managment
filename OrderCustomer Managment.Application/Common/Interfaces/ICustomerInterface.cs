using OrderCustomer_Managment.Domain.Entities;

namespace OrderCustomer_Managment.Application.Common.Interfaces;

public interface ICustomerInterface
{
    Task AddAsync(Customer customer);
    Task UpdateAsync(Customer customer);
    Task DeleteAsync(Guid id);
    Task<Customer?> GetByIdAsync(Guid id);
    Task<IEnumerable<Customer>> GetAllAsync();
}
