
namespace OrderCustomer_Managment.Application.Models.Order.DTOs;

public class OrderDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Count { get; set; }
}
