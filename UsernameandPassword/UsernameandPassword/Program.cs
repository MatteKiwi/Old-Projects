using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace UsernameandPassword
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.ForegroundColor = ConsoleColor.Red;

            Start: // Checkpoint for restarting the program
           
            string nouser = "Enter username";   // string for making Enter username look cool

            foreach (char c in nouser)          // makes its look cool for 50 ms delay i think??

            {

                Console.Write(c);

                Thread.Sleep(50);
                    

            }

            Console.WriteLine();
            string user = Console.ReadLine();
            Console.WriteLine();

            string nopass = "Enter password ";       // same thing 

            foreach (char c in nopass)

            {

                Console.Write(c);

                Thread.Sleep(50);

            }
            Console.WriteLine();
            string pass = Console.ReadLine();
            Console.WriteLine();

            if (user == "noname" || user == "Noname" && pass == "nopass" || pass == "Nopass")  // if switch? for getting in the program with a welcome text being displayed

            {
               
                Console.WriteLine("Welcome ");
               
            }
                
            else
            {
                Console.WriteLine();
                Console.WriteLine("Wrong Username or Password ");   // if noname and nopass is not typed, this is the text that get's displayed
                Console.WriteLine();

                Thread.Sleep(1000); Console.Clear();
                goto Start;  // goes to the start checkpoint in the begining?
            }

            string h = "Welcome";  // fun little for loop thats displayes welcome 32 times with a 100 ms delay.

            for (int i = 0; i < 32; i++)
            {
                Console.WriteLine(h);
                Thread.Sleep(100);

            }

            Console.ReadLine();




        }
    }
}
