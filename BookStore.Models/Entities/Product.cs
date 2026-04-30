using ShpoNest.Models.Enums;

namespace ShpoNest.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        //Book Space
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? ISBN { get; set; }
        public int? PublicationYear { get; set; }
        public int? Pages { get; set; }
        public string? Language { get; set; }
        public string? Edition { get; set; }
        public BookFormat? Format { get; set; }


        //Fk
        public int CategoryId { get; set; }

        //Nav prop
        public Category Category { get; set; }
        public ICollection<ProductImages> Images { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
