using OrderCustomer_Managment.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using OrderCustomer_Managment.Infrastructure.Persistence;
using OrderCustomer_Managment.Domain.Entities;

namespace OrderCustomer_Managment.Infrastructure.Repository;

public class OrderRepository : IOrderInterface
{
    // inyeccion de dbContext - Constructor
    private readonly ApplicationDbContext _context;

    public OrderRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    //metodos
    public async Task AddAsync(Order order)
    {
        await _context.Orders.AddAsync(order);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Order order)
    {
        _context.Orders.Update(order);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var order = await _context.Orders.FindAsync(id);
        if (order != null)
        {
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }
    }
    public async Task<Order?> GetByIdAsync(Guid id)
    {
        return await _context.Orders.FindAsync(id);

    }
    public async Task<IEnumerable<Order>> GetAllAsync()
    {
        return await _context.Orders.ToListAsync();
        return await _context.Orders.ToListAsync();
    }
}
