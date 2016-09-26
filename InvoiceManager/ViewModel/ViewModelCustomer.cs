using GalaSoft.MvvmLight;

namespace InvoiceManager.ViewModel
{
    public class ViewModelCustomer : ViewModelBase
    {
        #region Members
        private int _id;
        private string _name;
        private string _address;
        private string _city;
        private string _postalCode;
        private string _phoneNumberResidential;
        private string _creationDate;
        private bool _isActive;
        #endregion

        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; RaisePropertyChanged("ID"); }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged("Name"); }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; RaisePropertyChanged("Address"); }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; RaisePropertyChanged("City"); }
        }

        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; RaisePropertyChanged("PostalCode"); }
        }

        public string PhoneNumberResidential
        {
            get { return _phoneNumberResidential; }
            set { _phoneNumberResidential = value; RaisePropertyChanged("PhoneNumberResidential"); }
        }

        public string CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; RaisePropertyChanged("CreationDate"); }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; RaisePropertyChanged("IsActive"); }
        }
        #endregion
    }
}