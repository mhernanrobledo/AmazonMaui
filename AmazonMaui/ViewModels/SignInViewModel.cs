namespace AmazonMaui.ViewModels
{
    public partial class SignInViewModel : BaseViewModel
    {
        public SignInViewModel()
        {
            Title = "Sign In";
        }

        [RelayCommand]
        async Task SignIn()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                await Shell.Current.GoToAsync("//AmazonMaui/HomePage", false);
                //await Shell.Current.GoToAsync($"{nameof(HomeView)}", false);
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

        [RelayCommand]
        async Task ForgotPassword()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                await Shell.Current.DisplayAlert("Informacion", "Opción no implementada en esta demo.", "OK");
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
        private async Task SignInWith()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                await Shell.Current.DisplayAlert("Informacion", "Opción no implementada en esta demo.", "OK");
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
