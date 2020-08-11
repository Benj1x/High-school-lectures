namespace Klasser
{
    class Book
    {
        private string title = "";
        private string ISBN = "";
        private bool isLend = true;
        private string writer = "";
        private int year = 0;

        public Book(string title, string ISBN, bool isLend, string writer, int year)
        {
            this.title = title;
            this.ISBN = ISBN;
            this.isLend = isLend;
            this.writer = writer;
            this.year = year;
        }

        public string getTitle()
        {
            return this.title;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        
        public bool isObsolete(int year) { return true; }

    }
}