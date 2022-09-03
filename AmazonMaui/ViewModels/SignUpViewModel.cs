namespace AmazonMaui.ViewModels
{
    public partial class SignUpViewModel : BaseViewModel
    {
        public SignUpViewModel()
        {
            Title = "Sign Up";
        }

        [RelayCommand]
        async Task CreateAccount()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                await Shell.Current.GoToAsync($"{nameof(HomeView)}", false);
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
        private async Task Cancel()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                await Shell.Current.GoToAsync("..", false);
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
