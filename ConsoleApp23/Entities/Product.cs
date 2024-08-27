namespace ConsoleApp23.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitStock { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public List<Order> Orders { get; set; }
    }
}
