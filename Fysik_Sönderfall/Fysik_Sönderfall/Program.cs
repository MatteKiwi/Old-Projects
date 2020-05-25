using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
   

namespace Fysik_Sönderfall
{
    class Program
    {
        static void Main(string[] args)
        {

            Random gen = new Random();

            int k = 0;
            int y = 0;
            int atomx = 1000;
            DateTime start = DateTime.Now;

            while (DateTime.Now.Subtract(start).Seconds < 13)
            {
                
                    int atom = gen.Next(1, 10);

                    
                        if (atom < 4)
                        {
                            y++;

                            Console.WriteLine("Decay!");
                        }
                        else if (atom >= 4)
                        {
                            k++;
                            Console.WriteLine("Survived!");
                        }


                Thread.Sleep(1000);
                

                Console.WriteLine("Number of decays: " + y + "\nNumber of Survivors: " + k);
                Console.WriteLine(atomx);
                Console.ReadLine();



            }



        }
    }
}
