using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace InvoiceManager.DockManager
{
    public abstract class DockWindowViewModel : ViewModelBase
    {
        #region Attributes
        private bool _IsClosed;
        private bool _CanClose;
        private string _Title;

        // Commands
        public static RelayCommand CloseCommand { get; private set; }
        #endregion

        #region Constructor
        public DockWindowViewModel()
        {
            // Properties
            CanClose = true;
            IsClosed = false;
            _Title = "New Invoice";

            // Commands
            CloseCommand = new RelayCommand(() => Close());
        }
        #endregion

        #region Properties
        public bool IsClosed
        {
            get { return _IsClosed; }
            set
            {
                if (_IsClosed != value)
                {
                    _IsClosed = value;
                    RaisePropertyChanged(nameof(IsClosed));
                }
            }
        }

        public bool CanClose
        {
            get { return _CanClose; }
            set
            {
                if (_CanClose != value)
                {
                    _CanClose = value;
                    RaisePropertyChanged(nameof(CanClose));
                }
            }
        }

        public string Title
        {
            get { return _Title; }
            set
            {
                if (_Title != value)
                {
                    _Title = value;
                    RaisePropertyChanged(nameof(Title));
                }
            }
        }
        #endregion

        #region Binding Commands
        public void Close()
        {
            if (CanClose)
            {
                IsClosed = true;
            }
        }
        #endregion
    }
}
