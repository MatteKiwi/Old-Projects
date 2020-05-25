using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser_instanser
{
    class Book
    {
        public string name;
        public int page;
        private int currentPage = 0;

        // public string content = "Hej";

        public void TurnPage()
        {
            for (int currentPage = 0; currentPage < page + 1; currentPage++)
            {
                Console.WriteLine("Sida:" + currentPage);


                Console.ReadLine();
            }
        }

        public int GetCurrentPage()
        {
            return currentPage;
        }

        public Book(string n, int p)
        {
            n = name;
            p = page;
        }

        public Book()
        {
        }

        public string GetName()
        {
            return name;
        }

        public int GetPages()
        {
            return page;
        }

    }
}
