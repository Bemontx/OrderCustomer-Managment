

using MediatR;
using OrderCustomer_Managment.Domain.Enum;

namespace OrderCustomer_Managment.Application.Models.Customer.Commands;

public class UpdateCustomerCommand : IRequest<bool>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Adress { get; set; }
    public States States { get; set; }
}
