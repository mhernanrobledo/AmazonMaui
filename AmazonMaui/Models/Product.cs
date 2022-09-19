namespace AmazonMaui.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<string> Images { get; set; }
        public string ImageUrl => Images.FirstOrDefault();
        
        // Flags
        public bool IsOnStock { get; set; } = false;
        public bool IsAmazonBestSeller { get; set; } = false;
        public bool IsAmazonChoice { get; set; } = false;
        public bool IsAmazonLimitedTime { get; set; } = false;
        public bool IsAmazonPrime { get; set; } = false;

        public bool IsUserFavorite { get; set; } = false;
        // Relationships
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        /// <summary>
        /// Returns the name of the product and the list price.
        /// </summary>
        public override string ToString() => $"{Name} \n{Price}";
    }
}
