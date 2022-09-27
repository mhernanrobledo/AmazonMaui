namespace AmazonMaui.Extensions
{
    public static class ViewsExtensions
    {
        public static MauiAppBuilder ConfigureViews(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<SplashScreenView>();
            builder.Services.AddSingleton<OnboardingView>();
            builder.Services.AddSingleton<WelcomeViewModel>();
            builder.Services.AddTransient<SignInView>();
            builder.Services.AddTransient<SignUpView>();
            builder.Services.AddSingleton<HomeView>();
            builder.Services.AddTransient<ProductDetailView>();
            builder.Services.AddTransient<ProductReviewsView>();
            builder.Services.AddSingleton<FavoritesView>();
            builder.Services.AddSingleton<SearchView>();
            builder.Services.AddSingleton<ShoppingCartView>();
            builder.Services.AddTransient<SettingsView>();
            

            return builder;
        }
    }
}
