using System;
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
            basket.add(volume1);
            basket.add(volume2);
            //Assert
            Assert.Equal(23.20, basket.getTotalPrice());
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
            basket.add(volume1);
            basket.add(volume2);
            basket.add(volume3);
            //Assert
            Assert.Equal(29.60, basket.getTotalPrice());
        }

        [Fact]
        public void four_different_books_you_get_a_twenty_percent_discount()
        {
            //Assign
            Book volume1 = new Book("V1");
            Book volume2 = new Book("V2");
            Book volume3 = new Book("V3");
            Book volume4 = new Book("V4");
            Basket basket = new Basket();
            //Act
            basket.add(volume1);
            basket.add(volume1);
            basket.add(volume2);
            basket.add(volume3);
            basket.add(volume4);
            //Assert
            Assert.Equal(33.60, basket.getTotalPrice());
        }

        [Fact]
        public void five_different_books_you_get_a_twenty_five_percent_discount()
        {
            //Assign
            Book volume1 = new Book("V1");
            Book volume2 = new Book("V2");
            Book volume3 = new Book("V3");
            Book volume4 = new Book("V4");
            Book volume5 = new Book("V5");
            Basket basket = new Basket();
            //Act
            basket.add(volume1);
            basket.add(volume1);
            basket.add(volume2);
            basket.add(volume2);
            basket.add(volume3);
            basket.add(volume4);
            basket.add(volume5);
            //Assert
            Assert.Equal(46.00, basket.getTotalPrice());
        }
    }
}
