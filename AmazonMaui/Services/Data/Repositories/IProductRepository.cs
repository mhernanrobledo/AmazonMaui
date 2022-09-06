namespace AmazonMaui.Services.Data.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetItemAsync(int productId);
        Task<IEnumerable<Product>> GetAmazonBestSellerProducts();
        Task<IEnumerable<Product>> GetAmazonChoiceProducts();
        Task<IEnumerable<Product>> GetAmazonLimitedTimeProducts();      
    }
}
