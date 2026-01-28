using OrderCustomer_Managment.Domain.Enum;

namespace OrderCustomer_Managment.Domain.Entities;

public class Customer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Adress { get; set; }
    public States States { get; set; }
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public DateTime CreatedDate { get; set; }= DateTime.Now;

}
