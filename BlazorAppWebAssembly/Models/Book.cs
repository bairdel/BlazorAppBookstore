namespace BlazorAppWebAssembly.Models
{
    public class Book
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public required string Genre { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
