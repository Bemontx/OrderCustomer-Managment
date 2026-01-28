using MediatR;
using OrderCustomer_Managment.Application.Models.Customer.DTOs;

namespace OrderCustomer_Managment.Application.Models.Customer.Queries;

public class CustomerGetAllQuery : IRequest<IEnumerable<CustomerDto>>
{
}
