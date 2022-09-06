namespace AmazonMaui.ViewModels
{
    public partial class WelcomeViewModel : BaseViewModel
    {
        public WelcomeViewModel()
        {
            Title = String.Empty;
        }

        [RelayCommand]
        async Task SignIn()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                await Shell.Current.GoToAsync($"{nameof(SignInView)}", false);
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

        [RelayCommand]
        async Task SignUp()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                await Shell.Current.GoToAsync($"{nameof(SignUpView)}", false);
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
