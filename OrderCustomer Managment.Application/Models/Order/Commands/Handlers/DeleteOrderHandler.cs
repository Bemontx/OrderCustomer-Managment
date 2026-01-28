using MediatR;
using OrderCustomer_Managment.Application.Common.Interfaces;

namespace OrderCustomer_Managment.Application.Models.Order.Commands.Handlers;

public class DeleteOrderHandler : IRequestHandler<DeleteOrderCommand, Unit>
{
    private readonly IOrderInterface _orderRepository;
    public DeleteOrderHandler(IOrderInterface orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
    {
        await _orderRepository.DeleteAsync(request.Id);
        return Unit.Value;
    }

}
