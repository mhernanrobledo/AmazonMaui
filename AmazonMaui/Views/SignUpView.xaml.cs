namespace AmazonMaui.Views;

public partial class SignUpView : ContentPage
{
    private readonly SignUpViewModel _viewModel;
    public SignUpView(SignUpViewModel viewModel)
	{
		InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    protected override bool OnBackButtonPressed() => true;
}