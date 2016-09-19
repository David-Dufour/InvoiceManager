namespace InvoiceManager.Model
{
    public class Invoice
    {
        public string Title
        {
            get;
            private set;
        }

        public Invoice(string title)
        {
            Title = title;
        }
    }
}