namespace AmazonMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .ConfigureEssentials()
            .UseMauiCommunityToolkit()
            .ConfigureServices()
            .ConfigureViewModels()
            .ConfigureViews()
            .ConfigureFonts(fonts =>
			{
				//fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				//fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("RobotoBlack.ttf", "RobotoBlack");
                fonts.AddFont("RobotoBold.ttf", "RobotoBold");
                fonts.AddFont("RobotoLight.ttf", "RobotoLight");
                fonts.AddFont("RobotoMedium.ttf", "RobotoMedium");
                fonts.AddFont("RobotoRegular.ttf", "RobotoRegular");
                fonts.AddFont("RobotoThin.ttf", "RobotoThin");
                fonts.AddFont("FASolid.otf", "FontAwesome");
            });

		return builder.Build();
	}
}
