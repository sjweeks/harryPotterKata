using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace harryPotterKata2
{
    internal class Basket
    {
        List<Book> books = new List<Book>();
        public Basket()
        {
        }

        internal void add(Book book)
        {
            books.Add(book);
        }

        internal double getTotalPrice()
        {

            return new Discount().generateDiscount(books);
        }
    }
}