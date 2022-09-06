namespace AmazonMaui.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public string Icon { get; set; }
        public List<Product> ProductsInCategory { get; set; } = new List<Product>();
        public int NumberOfItems => ProductsInCategory.Count; // Numero de items por categoria
        public override string ToString() => $"{CategoryId}\n{Name}";
    }
}
