namespace AmazonMaui.ViewModels
{
    public partial class ProductReviewsViewModel : BaseViewModel
    {
        [ObservableProperty]
        private Product _product;

        public ProductReviewsViewModel()
        {
            Title = "Rating and Reviews";
        }

        public override void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            _product = query["SelectedProduct"] as Product;
            OnPropertyChanged(nameof(Product));

           // Title = Product.Name;
        }
    }
}
