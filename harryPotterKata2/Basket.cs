﻿using System;
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
                basketTotal *= fivePercentDiscount;
            }
            else if (books.Distinct().Count() == 3)
            {
                basketTotal *= tenPercentDiscount;
            }
            else if(books.Distinct().Count() == 4)
            {
                basketTotal *= twentyPercentDiscount;
            }
            else if(books.Distinct().Count() == 5)
            {
                basketTotal *= twentyFivePercentDiscount;
            }
            return basketTotal;
        }
    }
}