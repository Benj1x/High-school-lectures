using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    class Book
    {
        private string title = "";
        private string author = "";
        private string ISBN = "";
        private string year = "";
        private bool isLent = false;

        public Book(string title, string ISBN, bool isLent, string author, string year)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.year = year;
            this.isLent = false;
        }
        public string getTitle()
        {
            return this.title;
        }
        public void setTitle()
        {
            this.title = title;
        }
        public string getAuthor()
        {
            return this.author;
        }
        public void setAuthor()
        {
            this.author = author;
        }
        public string getISBN()
        {
            return this.ISBN;
        }
        public void setISBN()
        {
            this.ISBN = ISBN;
        }
        public string getYear()
        {
            return this.year;
        }
        public void setYear()
        {
            this.year = year;
        }
        public bool getIsLent()
        {
            return this.isLent;
        }
        public void setIsLent()
        {
            this.isLent = true;
        }
    }
}
