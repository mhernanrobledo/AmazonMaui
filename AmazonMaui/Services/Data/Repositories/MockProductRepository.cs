namespace AmazonMaui.Services.Data.Repositories
{
    public class MockProductRepository : IProductRepository
    {
        private readonly List<Product> _productsList;
        public MockProductRepository()
        {
            _productsList = new List<Product>
            {
                new Product { ProductId = 1, CategoryId =1, Name="iPhone 13 Pro MAX", Price = 1232.99M, Images = new List<string>(){ "iphone_13_1.jpg", "iphone_13_2.jpg", "iphone_13_3.jpg", "iphone_13_4.jpg", "iphone_13_5.jpg"} , IsOnStock = true, IsAmazonBestSeller = false, IsAmazonChoice = true, IsAmazonLimitedTime = false, IsAmazonPrime = true, IsUserFavorite = true },
                new Product { ProductId = 2, CategoryId =1, Name="Samsung Galaxy A53",Price = 353.00M,  Images = new List<string>(){ "galaxy_a53_1.jpg", "galaxy_a53_2.jpg", "galaxy_a53_3.jpg"}, IsOnStock = true, IsAmazonBestSeller = true, IsAmazonChoice = false },
                new Product { ProductId = 3, CategoryId =1, Name="Xiaomi Redmi Note 11S",Price = 206.82M,  Images = new List<string>(){ "redmi_1.jpg", "redmi_2.jpg", "redmi_3.jpg" } },
                new Product { ProductId = 4, CategoryId =2, Name="MacBook Air M2", Price = 1359.99M,  Images = new List<string>(){ "macbook_air1.jpg", "macbook_air2.jpg", "macbook_air3.jpg" } },
                new Product { ProductId = 5, CategoryId =2, Name="MacBook Pro 14", Price = 2425M,  Images = new List<string>(){ "macbook_1.jpg", "macbook_1.jpg" } },
            };
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await Task.FromResult(_productsList);
        }

        public async Task<Product> GetItemAsync(int productId)
        {
            return await Task.FromResult(_productsList.FirstOrDefault(p => p.ProductId == productId));
        }

        public async Task<IEnumerable<Product>> GetAmazonBestSellerProducts()
        {
            return await Task.FromResult(_productsList?.Where(p => p.IsAmazonBestSeller));
        }

        public async Task<IEnumerable<Product>> GetAmazonChoiceProducts()
        {
            return await Task.FromResult(_productsList?.Where(p => p.IsAmazonChoice));
        }

        public async Task<IEnumerable<Product>> GetAmazonLimitedTimeProducts()
        {
            return await Task.FromResult(_productsList?.Where(p => p.IsAmazonLimitedTime));
        }
    }
}
