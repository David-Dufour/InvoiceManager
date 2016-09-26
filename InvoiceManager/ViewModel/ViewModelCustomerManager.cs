using System.Collections.Generic;

using InvoiceManager.DockManager;

namespace InvoiceManager.ViewModel
{
    public class ViewModelCustomerManager : DockWindowViewModel
    {
        private string _id;
        private IList<ViewModelCustomer> _customers = new List<ViewModelCustomer>();

        public string ID
        {
            get { return _id; }
            set { _id = value; RaisePropertyChanged("ID"); }
        }

        public IList<ViewModelCustomer> Customers
        {
            get { return _customers; }
            protected set { _customers = value; RaisePropertyChanged("Customers"); }
        }
    }
}
