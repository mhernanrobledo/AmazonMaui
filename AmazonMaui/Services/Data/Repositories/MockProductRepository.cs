namespace AmazonMaui.Services.Data.Repositories
{
    public class MockProductRepository : IProductRepository
    {
        private readonly List<Product> _productsList;
        public MockProductRepository()
        {
            _productsList = new List<Product>
            {
                new Product { ProductId = 1, CategoryId =1, Name="iPhone 13 Pro MAX", Images = new List<string>(){ "iphone_13_1.jpg", "iphone_13_2.jpg", "iphone_13_3.jpg", "iphone_13_4.jpg", "iphone_13_5.jpg"} , Price = 1232.99M, IsUserFavorite=true },
                new Product { ProductId = 2, CategoryId =2, Name="Samsung Galaxy A53", Images = new List<string>(){ "galaxy_a53_1.jpg", "galaxy_a53_2.jpg", "galaxy_a53_3.jpg"} , Price = 353.00M }
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
