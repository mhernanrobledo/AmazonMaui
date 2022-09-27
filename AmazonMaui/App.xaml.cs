namespace AmazonMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        InitializeApp();

        if (DeviceInfo.Idiom == DeviceIdiom.Phone)
        {
            MainPage = new AppShell();
        }
	}

    private void InitializeApp()
	{
        //App.Current.UserAppTheme = AppTheme.Dark;

        TheTheme.SetTheme();

        if (VersionTracking.IsFirstLaunchEver)
        {
            //_settingsService.UseMocks = true;
        }
    }
}
