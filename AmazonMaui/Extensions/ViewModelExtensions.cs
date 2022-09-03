namespace AmazonMaui.Extensions
{
    public static class ViewModelExtensions
    {
        public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<SplashScreenViewModel>();
            builder.Services.AddSingleton<OnboardingViewModel>();
            builder.Services.AddSingleton<WelcomeViewModel>();
            builder.Services.AddSingleton<HomeViewModel>();
            builder.Services.AddSingleton<SignInViewModel>();
            builder.Services.AddSingleton<SignUpViewModel>();


            return builder;
        }
    }
}
