using MediatR;
using OrderCustomer_Managment.Application.Common.Interfaces;

namespace OrderCustomer_Managment.Application.Models.Customer.Commands.Handlers;

public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, bool>
{
    private readonly ICustomerInterface _customerRepository;

    public UpdateCustomerHandler(ICustomerInterface customerInterface)
    {
        _customerRepository = customerInterface;
    }

    public async Task<bool> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = await _customerRepository.GetByIdAsync(request.Id);
        if (customer == null)
        {
            return false;
        }


        customer.Name = request.Name;
        customer.Adress = request.Adress;
        customer.States = request.States;

        await _customerRepository.UpdateAsync(customer);
        return true;
    }
}
