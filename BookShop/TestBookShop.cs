using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop
{
    class TestBookShop
    {
        static void Main()
        {
            Book book = new Book("Pod igoto","Ivan Vazov",15.90m);
            Console.WriteLine(book);
            Console.WriteLine();
            GoldenEditionBook goldBook = new GoldenEditionBook("Tutun","Dimitur Dimov",22.90m);
            Console.WriteLine(goldBook);
        }
    }
}
