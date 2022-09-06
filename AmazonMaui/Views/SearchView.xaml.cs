namespace AmazonMaui.Views;

public partial class SearchView : ContentPage
{
    private readonly SearchViewModel _viewModel;
    public SearchView(SearchViewModel viewModel)
	{
		InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
}