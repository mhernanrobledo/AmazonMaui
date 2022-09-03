namespace AmazonMaui.ViewModels
{
    public abstract partial class BaseViewModel : ObservableObject, IQueryAttributable
    {

        [ObservableProperty]
        private string _title;

        [ObservableProperty]
        private bool _isBusy;

        //string _title = string.Empty;
        //public string Title
        //{
        //    get { return _title; }
        //    set { SetProperty(ref _title, value); }
        //}


        bool _isNotBusy = true;
        public bool IsNotBusy
        {
            get => _isNotBusy;
            set
            {
                if (SetProperty(ref _isNotBusy, value))
                    IsBusy = !_isNotBusy;
            }
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            //return Task.FromResult(false);
            return Task.CompletedTask;
        }

        #region IQueryAttributable
        public virtual void ApplyQueryAttributes(IDictionary<string, object> query)
        {

        }

        #endregion IQueryAttributable
    }
}
