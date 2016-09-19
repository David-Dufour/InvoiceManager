using System.Collections.Generic;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

using InvoiceManager.DockManager;
using InvoiceManager.Model;
using System.Windows;

namespace InvoiceManager.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region Attributes
        private readonly IDataService _dataService;
        #endregion

        #region Properties
        public DockManagerViewModel DockManagerViewModel { get; private set; }

        public RelayCommand NewCommand { get; private set; }
        public RelayCommand OpenCommand { get; private set; }
        public RelayCommand SaveCommand { get; private set; }
        public RelayCommand CloseCommand { get; private set; }
        public RelayCommand ExitCommand { get; private set; }
        #endregion

        #region Constructor
        public MainViewModel(IDataService dataService)
        {
            // Temp
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        return;
                    }
                });

            // Docking Panels
            DockManagerViewModel = new DockManagerViewModel(new List<DockWindowViewModel>());

            // Binding Commands
            NewCommand = new RelayCommand(() => New());
            OpenCommand = new RelayCommand(() => Open());
            SaveCommand = new RelayCommand(() => Save());
            CloseCommand = new RelayCommand(() => Close());
            ExitCommand = new RelayCommand(() => Exit());
        }
        #endregion

        #region Binding Commands
        private void New()
        {
            DockManagerViewModel.Documents.Add(new ViewModelInvoice() { ID = "", Name = "New Invoice" });
        }

        private void Open()
        {
            int x = 0;
            x++;
        }

        private void Save()
        {
            int x = 0;
            x++;
        }

        private void Close()
        {
            int x = 0;
            x++;
        }

        private void Exit()
        {
            Application.Current.Shutdown();
        }
        #endregion
    }
}