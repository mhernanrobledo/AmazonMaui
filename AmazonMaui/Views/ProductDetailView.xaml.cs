namespace AmazonMaui.Views;

public partial class ProductDetailView : ContentPage
{
	private readonly ProductDetailViewModel _viewModel;
	public ProductDetailView(ProductDetailViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}
}