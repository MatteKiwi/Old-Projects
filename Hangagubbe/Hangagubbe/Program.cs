using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangagubbe
{
    class Program
    {
        static void Main(string[] args)
        {
           bool gameover = true;

            var listword = new List<string> { "book", "watermelon", "goat", "computer", "programming" };
            var random = new Random();
            int index = random.Next(listword.Count);

            string wordcount = (listword[index]);
                
            while (gameover)
            {
                Console.WriteLine("Hi there and welcome to Hangman!");
                Console.WriteLine("The word is " + wordcount.Length + " characters");
                //Console.WriteLine(listword[index]);
                Console.ReadLine();

                
            }


          
        }
    }
}
