namespace AmazonMaui.Extensions
{
    public static class ServicesExtensions
    {
        public static MauiAppBuilder ConfigureServices(this MauiAppBuilder builder)
        {
            //Common Services
            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

            return builder;
        }
    }
}
