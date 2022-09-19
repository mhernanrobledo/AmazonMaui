namespace AmazonMaui.Services.Data.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categoriesList;

        public MockCategoryRepository()
        {
            _categoriesList = new List<Category>
            {
                new Category{CategoryId= 0 ,  Name="All"},
                new Category{CategoryId= 1 ,  Name="Mobile"},
                new Category{CategoryId= 2 ,  Name="Computer"},
                new Category{CategoryId= 3 ,  Name="Home"},
                new Category{CategoryId= 4 ,  Name="Electronics"},
                new Category{CategoryId= 5 ,  Name="Fashion"}
            };
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await Task.FromResult(_categoriesList);
        }

        public async Task<Category> GetItemAsync(int categorytId)
        {
            return await Task.FromResult(_categoriesList.FirstOrDefault(c => c.CategoryId == categorytId));
        }
    }
}
