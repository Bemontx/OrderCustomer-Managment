using MediatR;
namespace OrderCustomer_Managment.Application.Models.Order.Commands;

public class UpdateOrderCommand : IRequest<bool>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Count { get; set; }
}
