namespace AmazonMaui.Views;

public partial class SignInView : ContentPage
{
    private readonly SignInViewModel _viewModel;
    public SignInView(SignInViewModel viewModel)
	{
		InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    protected override bool OnBackButtonPressed() => true;
}