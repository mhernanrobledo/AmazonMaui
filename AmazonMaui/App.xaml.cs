namespace AmazonMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        InitializeApp();

        MainPage = new AppShell();
	}

    private void InitializeApp()
	{
        if (VersionTracking.IsFirstLaunchEver)
        {
            //_settingsService.UseMocks = true;
        }
    }
}
