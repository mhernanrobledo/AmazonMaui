namespace AmazonMaui.Views;
public partial class SplashScreenView : ContentPage
{
    private readonly SplashScreenViewModel _viewModel;
    public SplashScreenView(SplashScreenViewModel viewModel)
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

    protected override bool OnBackButtonPressed() => true;
}