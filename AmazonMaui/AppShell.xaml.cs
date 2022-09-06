namespace AmazonMaui;

public partial class AppShell : Shell
{
	public AppShell()
	{
        RegisterRoutes();
        InitializeComponent();
	}

    private void RegisterRoutes()
    {
        Routing.RegisterRoute(nameof(WelcomeView), typeof(WelcomeView));
        Routing.RegisterRoute(nameof(OnboardingView), typeof(OnboardingView));
        Routing.RegisterRoute(nameof(SignInView), typeof(SignInView));
        Routing.RegisterRoute(nameof(SignUpView), typeof(SignUpView));
        Routing.RegisterRoute(nameof(HomeView), typeof(HomeView));
        Routing.RegisterRoute(nameof(ProductDetailView), typeof(ProductDetailView));
        Routing.RegisterRoute(nameof(ProductReviewsView), typeof(ProductReviewsView));
    }
}
