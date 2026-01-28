using MediatR;
using OrderCustomer_Managment.Application.Models.Customer.DTOs;

namespace OrderCustomer_Managment.Application.Models.Customer.Queries;

public class CustomerGetByIdQuery : IRequest<CustomerDto>
{
    public Guid CustomerId { get; set; }
    public CustomerGetByIdQuery(Guid customerId)
    {
        CustomerId = customerId;        
    }
}
