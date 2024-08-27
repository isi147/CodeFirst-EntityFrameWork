namespace ConsoleApp23.Entities;

public class Order
{
    public int Id { get; set; }
    public string Address { get; set; }
    public List<Product> Products { get; set; }
}
