﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace harryPotterKata2
{
    public class Class1
    {
        [Fact]
        public void One_copy_of_any_book_costs_eight_pounds()
        {
            Book book = new Book("");
            
            Assert.Equal(8.00, book.GetPrice());
        }

        [Fact]
        public void two_different_books_you_get_a_five_percentage_discount()
        {
            //Assign
            Book volume1 = new Book("V1");
            Book volume2 = new Book("V2");
            Basket basket = new Basket();
            //Act
            basket.add(volume1);
            basket.add(volume2);
            //Assert
            Assert.Equal(15.20, basket.getTotalPrice());
        }

        [Fact]
        public void three_different_books_you_get_a_ten_percentage_discount()
        {
            //Assign
            Book volume1 = new Book("V1");
            Book volume2 = new Book("V2");
            Book volume3 = new Book("V3");
            Basket basket = new Basket();
            //Act
            basket.add(volume1);
            basket.add(volume2);
            basket.add(volume3);
            //Assert
            Assert.Equal(21.60, basket.getTotalPrice());
        }
    }
}
