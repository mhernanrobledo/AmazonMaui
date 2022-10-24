namespace AmazonMaui.ViewModels
{
    public partial class OnboardingViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<OnboardingItem> _items;

        [ObservableProperty]
        private string _buttonText;

     
        private int _position;
        public int Position
        {
            get { return _position; }
            set 
            {
                _position = value;

                if (value == Items?.Count - 1)
                {
                    ButtonText = "Start";
                }
                else
                {
                    ButtonText = "Next";
                }

                OnPropertyChanged(nameof(Position));
                OnPropertyChanged(nameof(ButtonText));
            }
        }

        public OnboardingViewModel()
        {
            Title = String.Empty;
            Position = 0;
            ButtonText = "Next";

            Items = new ObservableCollection<OnboardingItem>
            {
                new OnboardingItem
                {
                    Title = "EASY SHOPPING",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquid ex ea commodi consequat. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est",
                    ImageURL= "onboarding1.JPG"
                },
                new OnboardingItem
                {
                    Title = "SECURE PAYMENTS",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquid ex ea commodi consequat. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est",
                    ImageURL= "onboarding2.JPG"
                },
                new OnboardingItem
                {
                    Title = "QUICK DELIVERIES",
                    Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquid ex ea commodi consequat. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est",
                    ImageURL= "onboarding3.JPG"
                }
            };
        }

        [RelayCommand]
        async Task Next()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                if(Position >= Items?.Count -1)
                {
                    await Shell.Current.GoToAsync(nameof(WelcomeView), false);
                }
                else
                {
                    Position += 1;
                }
               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        async Task Skip()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                await Shell.Current.GoToAsync(nameof(WelcomeView), false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
