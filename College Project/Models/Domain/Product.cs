namespace College_Project.Models.Domain
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string ImageURL {  get; set; }
    }
}
