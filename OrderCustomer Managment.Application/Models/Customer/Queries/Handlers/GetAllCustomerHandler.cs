using MediatR;
using OrderCustomer_Managment.Application.Common.Interfaces;
using OrderCustomer_Managment.Application.Models.Customer.DTOs;

namespace OrderCustomer_Managment.Application.Models.Customer.Queries.Handlers
{
    internal class GetAllCustomerHandler : IRequestHandler<CustomerGetAllQuery, IEnumerable<CustomerDto>>
    {
        private readonly ICustomerInterface _customerRepository;
        public GetAllCustomerHandler(ICustomerInterface customerRepository)
        {
            _customerRepository = customerRepository;
        }
       
        public async Task<IEnumerable<CustomerDto>> Handle(CustomerGetAllQuery request, CancellationToken cancellationToken)
        {
            var customers = await _customerRepository.GetAllAsync();
            var customerDtos = customers.Select(customer => new CustomerDto
            {
                Id = customer.Id,
                Name = customer.Name
            });
            return customerDtos;
        }

    }
}
