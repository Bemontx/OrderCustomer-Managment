using MediatR;
using OrderCustomer_Managment.Application.Common.Interfaces;

namespace OrderCustomer_Managment.Application.Models.Customer.Commands.Handlers;

public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, bool>
{
    private readonly ICustomerInterface _customerRepository;
    public DeleteCustomerHandler(ICustomerInterface customerRepository)
    {
        _customerRepository = customerRepository;
    }
    public async Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
    {
        await _customerRepository.DeleteAsync(request.Id);
        return true;
    }
{
}
