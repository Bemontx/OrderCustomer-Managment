using MediatR;
using OrderCustomer_Managment.Application.Common.Interfaces;

namespace OrderCustomer_Managment.Application.Models.Order.Commands.Handlers;

public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, Guid>
{
    private readonly IOrderInterface _orderRepository;
    public CreateOrderHandler(IOrderInterface orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public async Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = new Domain.Entities.Order
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Price = request.Price,
            Count = request.Count
        };
        await _orderRepository.AddAsync(order);
        return order.Id;
    }
}
