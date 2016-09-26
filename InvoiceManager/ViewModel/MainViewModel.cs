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
        private bool IsCustomerManagerOpen = false;
        #endregion

        #region Properties
        public DockManagerViewModel DockManager { get; private set; }
        public ViewModelCustomerManager CustomerManager { get; private set; }

        public RelayCommand NewCommand { get; private set; }
        public RelayCommand OpenCommand { get; private set; }
        public RelayCommand SaveCommand { get; private set; }
        public RelayCommand CloseCommand { get; private set; }
        public RelayCommand ExitCommand { get; private set; }
        public RelayCommand ManageClientsCommand { get; private set; }
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
            DockManager = new DockManagerViewModel(new List<DockWindowViewModel>());
            CustomerManager = new ViewModelCustomerManager();

            // Binding Commands
            NewCommand = new RelayCommand(() => New());
            OpenCommand = new RelayCommand(() => Open());
            SaveCommand = new RelayCommand(() => Save());
            CloseCommand = new RelayCommand(() => Close());
            ExitCommand = new RelayCommand(() => Exit());
            ManageClientsCommand = new RelayCommand(() => ManageClients());
        }
        #endregion

        #region Binding Commands
        private void New()
        {
            DockManager.Documents.Add(new ViewModelInvoice() { ID = "", Name = "New Invoice" });
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

        private void ManageClients()
        {
            if (!IsCustomerManagerOpen)
            {
                IsCustomerManagerOpen = true;
                DockManager.Documents.Add(CustomerManager);
            }
        }
        #endregion
    }
}