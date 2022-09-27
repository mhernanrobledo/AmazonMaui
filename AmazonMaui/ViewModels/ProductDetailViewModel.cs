namespace AmazonMaui.ViewModels
{
    public partial class ProductDetailViewModel : BaseViewModel, IQueryAttributable
    {
        [ObservableProperty]
        private Product _product;

        public override void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            _product = query["SelectedProduct"] as Product;
            OnPropertyChanged(nameof(Product));

            Title = Product.Name;
        }

        public ProductDetailViewModel()
        {
            
        }

        [RelayCommand]
        async Task ProductReviews()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                var navigationParameter = new Dictionary<string, object>
                {
                    { "SelectedProduct", _product }
                };
                await Shell.Current.GoToAsync($"{nameof(ProductReviewsView)}", navigationParameter);
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
