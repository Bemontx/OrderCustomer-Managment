using OrderCustomer_Managment.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using OrderCustomer_Managment.Infrastructure.Persistence;
using OrderCustomer_Managment.Domain.Entities;

namespace OrderCustomer_Managment.Infrastructure.Repository;

public class CustomerRepository : ICustomerInterface
{
    // inyeccion de dbContext - Constructor
    private readonly ApplicationDbContext _context;

    public CustomerRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    //metodos
    public async Task<Customer?> GetByIdAsync(Guid id)
    {
        return await _context.Customers.FindAsync(id);
    }

    public async Task AddAsync(Customer customer)
    {
        await _context.Customers.AddAsync(customer);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Customer customer)
    {
        _context.Customers.Update(customer);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer != null)
        {
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }
    }
    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
        return await _context.Customers.ToListAsync();
    }
}
