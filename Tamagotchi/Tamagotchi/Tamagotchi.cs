using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Tamagotchi
    {
        public string name;

        private int hunger = 0;

        private int boredom = 0;

        private bool isAlive = true;

        private List<string> words = new List<string>() { "Start", "Hoe", "Hello" };

        private static Random gen = new Random();

        public void Hi()
        {
            int index = gen.Next(words.Count);
            string randomWord = words[index];
            Console.WriteLine(randomWord);
            ReduceBoredom();
        }

        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();
        }

        public void PrintStats()
        {
            Console.WriteLine("Bordedom: " + boredom);
            Console.WriteLine("Hunger: " + hunger);
            if (isAlive == true)
            {
                Console.WriteLine("ye it lives");
            }
            else
            {
                Console.WriteLine("it dead");
            }
        }

        public void Tick()
        {
            if(hunger == 10 || boredom == 10)
            {
                isAlive = false;
            }
            else
            {
                hunger++;
                boredom++;
            }

        }

        public void Feed()
        {
            hunger--;
            if (hunger < 0)
            {
                hunger = 0;
            }
            
        }

        private void ReduceBoredom()
        {
            boredom--;
            if (boredom < 0)
            {
                boredom = 0;
            }
        }

        public bool GetAlive()
        {
            return isAlive;
        }
        
    }
}
