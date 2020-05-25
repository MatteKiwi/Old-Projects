using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        private static string GetName(string instructions)
        {
            string str = "";
            while (str.Length <= 0 || str.Length > 64)
            {
                Console.Write(instructions + ": ");
                str = Console.ReadLine();
                if (str.Length > 0)
                {
                    if (str.Length <= 64)
                    {
                        continue;
                    }
                    Console.WriteLine("För långt! Max 64 tecken!");
                }
                else
                {
                    Console.WriteLine("För kort!");
                }
            }
            return str;
        }

        private static int GetNumber()
        {
            int num = 0;
            bool flag = false;
            while (!flag)
            {
                Console.Write("Skriv ett tal: ");
                flag = int.TryParse(Console.ReadLine(), out num);
                if (flag)
                {
                    continue;
                }
                Console.WriteLine("Det där var inte ett giltigt tal!");
            }
            return num;
        }

        private static string GetStudent(bool firstNameFirst)
        {
            string name = Program.GetName("Förnamn");
            string str = Program.GetName("Efternamn");
            if (firstNameFirst)
            {
                return name + " " + str;
            }
            return str + " " + name;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("---=== KLASSLISTAN ===---");
            Console.WriteLine("Skriv först in hur många elever du vill lägga till i listan!");
            int number = Program.GetNumber();
            Console.WriteLine("Skapar " + number + " elever.");
            string[] student = new string[number];
            for (int i = 0; i < (int)student.Length; i++)
            {
                Console.WriteLine("Skapar elev #" + i + 1);
                student[i] = Program.GetStudent(false);
            }

            random[0] = random();
             

            Console.ReadLine();
        }
        static void random(string student)
        {
            Random random = new Random();
            int num = random.Next((int)student.Length);
            int num1 = random.Next((int)student.Length);
            Console.WriteLine("Slumpad elev 1: " + student[num]);
            Console.WriteLine("Slumpad elev 2: " + student[num1]);
            Console.ReadLine();
        }
    }
}
