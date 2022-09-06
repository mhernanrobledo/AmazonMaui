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
                new Category{CategoryId= 1 ,  Name="Mobiles"},
                new Category{CategoryId= 2 ,  Name=""},
                new Category{CategoryId= 3 ,  Name=""},
                new Category{CategoryId= 4 ,  Name=""},
                new Category{CategoryId= 5 ,  Name=""},
                new Category{CategoryId= 6 ,  Name=""},
                new Category{CategoryId= 7 ,  Name=""},
                new Category{CategoryId= 8 ,  Name=""},
                new Category{CategoryId= 9 ,  Name=""},
                new Category{CategoryId= 10 , Name=""},
                new Category{CategoryId= 11 , Name=""},
                new Category{CategoryId= 12 , Name=""}
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
