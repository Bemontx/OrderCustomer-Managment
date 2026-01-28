using MediatR;  
using OrderCustomer_Managment.Application.Common.Interfaces;
using OrderCustomer_Managment.Application.Models.Customer.DTOs;

namespace OrderCustomer_Managment.Application.Models.Customer.Queries.Handlers
{
    internal class GetByIdCustomerHandler : IRequestHandler<CustomerGetByIdQuery, CustomerDto>
    {
        private readonly ICustomerInterface _customerRepository;
        public GetByIdCustomerHandler(ICustomerInterface customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<CustomerDto> Handle(CustomerGetByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(request.Id);
            if (customer == null)
            {
                return null;
            }

            var customerDto = new CustomerDto
            {
                Id = customer.Id,
                Name = customer.Name
            };
            return customerDto;
        }
    }
}
