using InvoiceManager.DockManager;

namespace InvoiceManager.ViewModel
{
    public class ViewModelInvoice : DockWindowViewModel
    {
        private string _id;
        private string _name;

        public string ID
        {
            get { return _id; }
            set { _id = value; RaisePropertyChanged("ID"); }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged("Name"); }
        }
    }
}
