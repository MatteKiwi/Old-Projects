using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriskaKlasser
{
    class Program
    {
        delegate void DoThing();

        static void Hey()
        {
            Console.WriteLine("Hey");
        }

        static void Yey()
        {
            Console.WriteLine("Yey");
        }


        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            Queue<int> numbers = new Queue<int>();

            Random gen = new Random();
            int rngNum = gen.Next(1, 100);

            for (int i = 0; i < 2; i++)
            {
                numbers.Enqueue(rngNum);
                i++;
            }
            
            Stack<int> alsoNumbers = new Stack<int>();

            alsoNumbers.Push(6);

            int u = alsoNumbers.Pop();
             
            int y = numbers.Dequeue();

            Console.WriteLine(y);

            Dictionary<string, string> ordbok = new Dictionary<string, string>();

            ordbok["Mathias"] = "Elev";
            string g = ordbok.Keys.ToArray<string>()[0];

            Console.WriteLine(ordbok["Mathias"] + g);

            NormalThing g1 = new NormalThing();
            NormalThing g2 = new NormalThing();

            Dictionary<NormalThing, string> grejer = new Dictionary<NormalThing, string>();

            grejer[g1] = "Hej";

            Dictionary<string, DoThing> actions = new Dictionary<string, DoThing>();

            actions["1"] = Hey;
            actions["2"] = Yey;

            actions["1"]();

            Console.ReadLine();
        }
    }
}
