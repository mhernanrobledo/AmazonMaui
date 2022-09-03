namespace AmazonMaui.Views;

public partial class WelcomeView : ContentPage
{
	public WelcomeView()
	{
		InitializeComponent();
	}

    protected override bool OnBackButtonPressed() => true;
}