using System;

namespace InvoiceManager.Model
{
    public interface IDataService
    {
        void GetData(Action<Invoice, Exception> callback);
    }
}
