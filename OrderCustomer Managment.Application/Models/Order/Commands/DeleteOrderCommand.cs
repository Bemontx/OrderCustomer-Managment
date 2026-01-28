using MediatR;

namespace OrderCustomer_Managment.Application.Models.Order.Commands;

public class DeleteOrderCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
