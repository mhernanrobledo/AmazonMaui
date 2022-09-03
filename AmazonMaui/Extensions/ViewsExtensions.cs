namespace AmazonMaui.Extensions
{
    public static class ViewsExtensions
    {
        public static MauiAppBuilder ConfigureViews(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<SplashScreenView>();
            builder.Services.AddSingleton<OnboardingView>();
            builder.Services.AddSingleton<WelcomeViewModel>();
            builder.Services.AddSingleton<HomeView>();
            builder.Services.AddSingleton<SignInView>();
            builder.Services.AddSingleton<SignUpView>();

            return builder;
        }
    }
}
