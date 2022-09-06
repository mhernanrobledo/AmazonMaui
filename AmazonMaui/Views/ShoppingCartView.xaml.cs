namespace AmazonMaui.Views;

public partial class ShoppingCartView : ContentPage
{
    private readonly ShoppingCartViewModel _viewModel;
    public ShoppingCartView(ShoppingCartViewModel viewModel)
	{
		InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
}