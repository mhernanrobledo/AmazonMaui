namespace AmazonMaui.ViewModels
{
    public class SplashScreenViewModel : BaseViewModel
    {
        public SplashScreenViewModel()
        {
            Title = String.Empty;
        }

        public async Task InitializeAsync()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                await Task.Delay(1000);
                await Shell.Current.GoToAsync($"{nameof(OnboardingView)}", false);
                Shell.Current.FlyoutIsPresented = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
