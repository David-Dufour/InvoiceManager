using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace InvoiceManager.DockManager
{
    public class DockManagerViewModel
    {
        #region Properties
        public ObservableCollection<DockWindowViewModel> Documents { get; private set; }
        public ObservableCollection<object> Anchorables { get; private set; }
        #endregion

        #region Constructor
        public DockManagerViewModel(IEnumerable<DockWindowViewModel> dockWindowViewModels)
        {
            Documents = new ObservableCollection<DockWindowViewModel>();
            Anchorables = new ObservableCollection<object>();

            foreach (DockWindowViewModel document in dockWindowViewModels)
            {
                document.PropertyChanged += DockWindowViewModel_PropertyChanged;

                if (!document.IsClosed)
                {
                    Documents.Add(document);
                }
            }
        }
        #endregion

        #region Events
        private void DockWindowViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            DockWindowViewModel document = sender as DockWindowViewModel;

            if (e.PropertyName == nameof(DockWindowViewModel.IsClosed))
            {
                if (document.IsClosed)
                {
                    Documents.Remove(document);
                }
                else
                {
                    Documents.Add(document);
                }
            }
        }
        #endregion
    }
}
