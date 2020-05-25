using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSpend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Please create your character.");
            Console.WriteLine("You have 12 points to spend on Strength. ");
            Console.WriteLine("How many points would you like to spend on Strength? At least 1");
      
            int points = 12;
            int points2 = 0;
             
            while (true)
            {
                string input = Console.ReadLine();
                bool success = int.TryParse(input, out points2);         

                if (success && points2 >= 1 && points2 <= 12)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("This aint it chief");
                }
          
            } 

            points -= points2;                        
            Console.WriteLine("ALL DONE");
            Console.WriteLine("STRENGTH:" + points2);
            Console.WriteLine("Points left: " + points);
        
            Console.ReadLine();

        }
    }
}
