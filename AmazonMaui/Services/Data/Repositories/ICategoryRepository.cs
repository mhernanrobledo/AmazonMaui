namespace AmazonMaui.Services.Data.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetItemAsync(int categorytId);
    }
}
