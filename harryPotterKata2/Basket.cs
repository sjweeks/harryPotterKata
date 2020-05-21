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
            double basketTotal = 0;
            double discountTotal = 0;
            double fivePercentDiscount = 0.95;
            double tenPercentDiscount = 0.90;
            double twentyPercentDiscount = 0.80;
            double twentyFivePercentDiscount = 0.75;
            foreach (var book in books)
            {
                basketTotal += book.GetPrice();
            }
            if (books.Distinct().Count() == 2)
            {
                discountTotal = (2 * 8) * fivePercentDiscount;

                basketTotal = discountTotal + ((books.Count() - 2) * 8);
            }
            else if (books.Distinct().Count() == 3)
            {
                discountTotal = (3 * 8) * tenPercentDiscount;

                basketTotal = discountTotal + ((books.Count() - 3) * 8);
            }
            else if(books.Distinct().Count() == 4)
            {
                discountTotal = (4 * 8) * twentyPercentDiscount;

                basketTotal = discountTotal + ((books.Count() - 4) * 8);
            }
            else if(books.Distinct().Count() == 5)
            {
                discountTotal = (5 * 8) * twentyFivePercentDiscount;

                basketTotal = discountTotal + ((books.Count() - 5) * 8);
            }
            return basketTotal;
        }
    }
}