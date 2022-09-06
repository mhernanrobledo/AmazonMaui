namespace AmazonMaui.ViewModels
{
    public abstract partial class BaseViewModel : ObservableObject, IQueryAttributable
    {

        [ObservableProperty]
        private string _title;

        [ObservableProperty]
        private bool _isBusy = false;
        
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
