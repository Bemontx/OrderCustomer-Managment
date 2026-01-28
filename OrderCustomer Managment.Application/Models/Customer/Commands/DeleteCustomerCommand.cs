
using MediatR;

namespace OrderCustomer_Managment.Application.Models.Customer.Commands;

public class DeleteCustomerCommand : IRequest<bool>
{
    public Guid Id { get; set; }
}
