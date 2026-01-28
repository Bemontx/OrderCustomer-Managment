
namespace OrderCustomer_Managment.Domain.Entities;

public class Order
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Count { get; set; }
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
}
