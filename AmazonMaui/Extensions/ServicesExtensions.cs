using AmazonMaui.Services.Data;

namespace AmazonMaui.Extensions
{
    public static class ServicesExtensions
    {
        public static MauiAppBuilder ConfigureServices(this MauiAppBuilder builder)
        {
            //Common Services
            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
            //Amazon Services
            builder.Services.AddSingleton<ICategoryRepository, MockCategoryRepository>();
            builder.Services.AddSingleton<IProductRepository, MockProductRepository>();
            builder.Services.AddSingleton<IFavoritesService, FavoritesService>();

            return builder;
        }
    }
}
