using System;
using InvoiceManager.Model;

namespace InvoiceManager.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<Invoice, Exception> callback)
        {
            // Use this to create design time data

            var item = new Invoice("Welcome to MVVM Light [design]");
            callback(item, null);
        }
    }
}