
namespace AmazonMaui.Helpers
{
    public static class TheTheme
    {
        public static void SetTheme()
        {
            App.Current.UserAppTheme = Settings.Theme switch
            {
                AppTheme.Dark => AppTheme.Dark,
                _ => AppTheme.Light,
            };
            //MessagingCenter.Instance.Send<string>("AmazonMaui", "ChangeTheme");
        }
    }
}
