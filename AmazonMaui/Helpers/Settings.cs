﻿
namespace AmazonMaui.Helpers
{
    public static class Settings
    {
        const AppTheme _theme = AppTheme.Light;

        public static AppTheme Theme
        {
            get => Enum.Parse<AppTheme>(Preferences.Get(nameof(Theme), Enum.GetName(_theme)));
            set => Preferences.Set(nameof(Theme), value.ToString());
        }
    }
}
