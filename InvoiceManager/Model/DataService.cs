using System;

namespace InvoiceManager.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<Invoice, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new Invoice("Welcome to MVVM Light");
            callback(item, null);
        }
    }
}