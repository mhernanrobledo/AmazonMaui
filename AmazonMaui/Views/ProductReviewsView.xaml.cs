namespace AmazonMaui.Views;

public partial class ProductReviewsView : ContentPage
{
    private readonly ProductReviewsViewModel _viewModel;
    public ProductReviewsView(ProductReviewsViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}
}