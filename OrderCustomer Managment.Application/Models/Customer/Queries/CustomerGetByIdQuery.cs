using MediatR;
using OrderCustomer_Managment.Application.Models.Customer.DTOs;

namespace OrderCustomer_Managment.Application.Models.Customer.Queries;

public class CustomerGetByIdQuery : IRequest<CustomerDto>
{
    public Guid Id { get; set; }
    public CustomerGetByIdQuery(Guid id)
    {
        Id = id;        
    }
}
