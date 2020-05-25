using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser_instanser
{
    class Program
    {
        static void Main(string[] args)
        {

            // var BookList = new List<Book>();

              Book Kemi = new Book() { name = "Kemi 1", page = 27 };
              Book Matte = new Book() { name = "Matte 3c", page = 35 };
              Book Historia = new Book() { name = "Hitlers liv", page = 15 };
              Book Fysik = new Book() { name = "Andreas Fysik", page = 9 };

            
            Console.WriteLine("Vilken bok vill du läsa?");
            Console.WriteLine("A = Kemi, B = Matte, C = Historia, D = Fysik");
            string input = Console.ReadLine();
            string input2 = input.ToLower();


            if (input2 == "a")
            {
                Kemi.TurnPage();
            }
            else if (input2 == "b")
            {
                Matte.TurnPage();
            }
            else if (input2 == "c")
            {
                Historia.TurnPage();
            }
            else if (input2 == "d")
            {
                Fysik.TurnPage();
            }

            

            Console.ReadLine();

        }


    }

    



}
