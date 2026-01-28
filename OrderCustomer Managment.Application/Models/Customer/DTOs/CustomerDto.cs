

namespace OrderCustomer_Managment.Application.Models.Customer.DTOs;

public class CustomerDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Adress { get; set; }
    public DateTime CreatedDate { get; set; }= DateTime.Now;
}
