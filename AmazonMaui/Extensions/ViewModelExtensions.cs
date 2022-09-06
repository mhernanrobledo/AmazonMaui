namespace AmazonMaui.Extensions
{
    public static class ViewModelExtensions
    {
        public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<SplashScreenViewModel>();
            builder.Services.AddSingleton<OnboardingViewModel>();
            builder.Services.AddSingleton<WelcomeViewModel>();
            builder.Services.AddTransient<SignInViewModel>();
            builder.Services.AddTransient<SignUpViewModel>();
            builder.Services.AddSingleton<HomeViewModel>();
            builder.Services.AddSingleton<ProductDetailViewModel>();
            builder.Services.AddSingleton<ProductReviewsViewModel>();
            builder.Services.AddSingleton<FavoritesViewModel>();
            builder.Services.AddSingleton<SearchViewModel>();
            builder.Services.AddSingleton<ShoppingCartViewModel>();
            builder.Services.AddSingleton<SettingsViewModel>();
            

            return builder;
        }
    }
}
