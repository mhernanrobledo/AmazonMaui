namespace AmazonMaui.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {

        private bool _isDarkModeEnabled;

        public bool IsDarkModeEnabled
        {
            get => _isDarkModeEnabled;
            set
            {
                if (SetProperty(ref _isDarkModeEnabled, value))
                {
                    SettingsViewModel.ChangeUserAppTheme(value);
                }
            }
        }

        public SettingsViewModel()
        {
            Title = "Settings";
            _isDarkModeEnabled = Settings.Theme == AppTheme.Dark;
        }

        private static void ChangeUserAppTheme(bool activateDarkMode)
        {
            Settings.Theme = activateDarkMode
                ? AppTheme.Dark
                : AppTheme.Light;

            TheTheme.SetTheme();
        }
    }
}
