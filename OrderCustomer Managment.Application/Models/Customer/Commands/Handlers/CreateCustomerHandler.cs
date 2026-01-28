using MediatR;
using OrderCustomer_Managment.Application.Common.Interfaces;

namespace OrderCustomer_Managment.Application.Models.Customer.Commands.Handlers;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, Guid>
{
    private readonly ICustomerInterface _customerRepository;
    public CreateCustomerHandler(ICustomerInterface customerInterface)
    {
        _customerRepository = customerInterface;
    }
    //aca use  gemini ya que tuve un error en la promesa de async en el parametro de respuesta
    public async Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = new Domain.Entities.Customer
        {
            Name = request.Name,
            Adress = request.Adress,
            States = request.States
        };
        await _customerRepository.AddAsync(customer);
        return customer.Id;
    }
}
