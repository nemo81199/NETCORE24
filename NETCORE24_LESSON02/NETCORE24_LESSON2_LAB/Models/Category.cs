namespace NETCORE24_LESSON2_LAB.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Images { get; set; }
        public double Price { get; set; }
        public double SalePrice { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
    }
}
