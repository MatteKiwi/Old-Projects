using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klockan
{
    class Program
    {
        static void Main(string[] args)
        {

           int timer;
            
            int min;
            
            int sec;
         
            
            Console.WriteLine("Enter the current time, HH:mm:ss");
            
            Console.WriteLine("Hour: ");
            
            timer = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Minute: ");
            
            min = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Second: ");
            
            sec = int.Parse(Console.ReadLine());
            
            while (!Console.KeyAvailable)
            
            {
            
                System.Threading.Thread.Sleep(1000);
            
            Console.Clear();
            
                //n:D2 adds two decimals, so it doesn't end up with single digit counting

            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", timer, min, sec);
             
            sec++;
             
            if (sec == 60)
             
            {
             
                sec = 0;
             
                min++;
             
            }
             
                if (min == 60)
             
                {
             
                    min = 0;
             
                    timer++;
  
                }
             
                if (timer == 24)
                {
                  timer = 0;
                }
             
            } 




              while (!Console.KeyAvailable)

              {
                  Console.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));


                  System.Threading.Thread.Sleep(1000);

                  Console.Clear();

              } 


        }
    }
}
