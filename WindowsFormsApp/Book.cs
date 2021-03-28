using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class Book
    {
        public Book(string subject, string author, double unitPrice)
        {
            Subject = subject;
            Author = author;
            UnitPrice = unitPrice;
        }

        public Book() {}

        public string Subject { get; set; }
        public string Author { get; set; }
        public double UnitPrice { get; set; }
    }
}
