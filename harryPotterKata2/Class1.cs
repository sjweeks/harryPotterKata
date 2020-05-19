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
            Book book = new Book();
            
            Assert.Equal(8.00, book.GetPrice());
        }
    }
}
