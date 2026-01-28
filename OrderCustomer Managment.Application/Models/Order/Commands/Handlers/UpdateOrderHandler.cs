using MediatR;
using OrderCustomer_Managment.Application.Common.Interfaces;

namespace OrderCustomer_Managment.Application.Models.Order.Commands.Handlers;

public class UpdateOrderHandler : IRequestHandler<UpdateOrderCommand, bool>
{
    private readonly IOrderInterface _orderRepository;
    public UpdateOrderHandler(IOrderInterface orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public async Task<bool> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = await _orderRepository.GetByIdAsync(request.Id);
        if (order == null)
        {
            return false; 
        }

        order.Name = request.Name;
        order.Price = request.Price;
        order.Count = request.Count;
        await _orderRepository.UpdateAsync(order);
        return true;
    }
}
