namespace AmazonMaui.Views;

public partial class HomeView : ContentPage
{
    private readonly HomeViewModel _viewModel;
    public HomeView(HomeViewModel viewModel)
	{
		InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.InitializeAsync();
    }
}