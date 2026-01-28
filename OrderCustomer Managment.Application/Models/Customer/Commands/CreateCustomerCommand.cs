using MediatR;
using OrderCustomer_Managment.Domain.Enum;

namespace OrderCustomer_Managment.Application.Models.Customer.Commands;

public class CreateCustomerCommand : IRequest<Guid>
{
    public string Name { get; set; }
    public string Adress { get; set; }
    public States States { get; set; }
}
