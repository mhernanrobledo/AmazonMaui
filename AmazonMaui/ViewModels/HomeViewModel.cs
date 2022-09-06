namespace AmazonMaui.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        [ObservableProperty]
        ObservableCollection<Category> _categoryProducts;

        [ObservableProperty]
        private Category _selectedCategory;

        [ObservableProperty]
        ObservableCollection<Product> _products;

        [ObservableProperty]
        private Product _selectedProduct;

        public ICommand ProductDetailCommand { get; }

        public HomeViewModel(ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            Title = "Home";

            _categoryRepository = categoryRepository;
            _productRepository = productRepository;

            CategoryProducts = new ObservableCollection<Category>();
            Products = new ObservableCollection<Product>();

            ProductDetailCommand = new Command(NavigateToProductDetail);
        }

        public async Task InitializeAsync()
        {
            IsBusy = true;
            try
            {
                CategoryProducts.Clear();
                var categories =  await _categoryRepository.GetAllCategories();
                foreach (var item in categories)
                {
                    CategoryProducts.Add(item);
                }

                _selectedCategory = CategoryProducts[0];
                OnPropertyChanged(nameof(SelectedCategory));

                Products.Clear();
                var products = await _productRepository.GetAllProducts();
                foreach (var item in products)
                {
                    Products.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async void NavigateToProductDetail(object sender)
        {
           // Debug.WriteLine(sender);

            if (sender == null)
                return;

            if (IsBusy)
                return;

            IsBusy = true;
            try
            {
                Product selectedProduct = sender as Product;

                // This will push the ProductDetailView onto the navigation stack
                var navigationParameter = new Dictionary<string, object>
                {
                    { "SelectedProduct", selectedProduct }
                };

                await Shell.Current.GoToAsync($"{nameof(ProductDetailView)}", navigationParameter);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }

            
        }

    }
}
