namespace AmazonMaui.Views;

public partial class FavoritesView : ContentPage
{
    private readonly FavoritesViewModel _viewModel;
    public FavoritesView(FavoritesViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
        BindingContext = _viewModel;
    }
}