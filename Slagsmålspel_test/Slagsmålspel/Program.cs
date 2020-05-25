using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Slagsmålspel
{
    class Program
    {
        static void hpnumbers()
        {

        }
        static void hpcheck()
        {
            int hp = 100;
            int hp2 = 100;
            if (hp <= 0)
            {
                Console.WriteLine("You Lost");
            }
            if (hp2 <= 0)
            {
                Console.WriteLine("You won");
            } 
        }
        
        static void Main(string[] args)
        {
            int hp = 100;
            int hp2 = 100;
            int damage = 0;
            int acc = 0;
            int HeavyAttack = 0;
            int QuickAttack = 0;
            string PlayerA = "";
            string replay = "";
           
            // int crit = 0; 

            Random generator = new Random();

                    

                while (replay != "no")
                {
                    string art = @" _   _ _______ _____   ______ _____ _____ _______ _    _ ______ _____  
 | \ | |__   __|_   _| |  ____|_   _/ ____|__   __| |  | |  ____|  __ \ 
 |  \| |  | |    | |   | |__    | || |  __   | |  | |__| | |__  | |__) |
 | . ` |  | |    | |   |  __|   | || | |_ |  | |  |  __  |  __| |  _  / 
 | |\  |  | |   _| |_  | |     _| || |__| |  | |  | |  | | |____| | \ \ 
 |_| \_|  |_|  |_____| |_|    |_____\_____|  |_|  |_|  |_|______|_|  \_\
                                                                        ";
                    Console.WriteLine(art);
                    Console.WriteLine("Welcome to NTI FIGHTER");
                    Console.WriteLine("Press Enter to start");
                    Console.ReadLine();
                    Console.WriteLine("What's your name fighter");


                    while (PlayerA.Length <= 3 || PlayerA.Length >= 32)
                    {
                        Console.WriteLine("Choose your Fighter name (4-32 characters):");
                        PlayerA = Console.ReadLine();
                    }
                    Console.WriteLine("Congratulations! " + PlayerA + " works!");

                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Well welcome " + PlayerA + " Who do you wanna fight");
                    Console.WriteLine("A = ÄRIK");
                    Console.WriteLine("B = ROBINO");
                    Console.WriteLine("C = ROBERTO");
                    Console.WriteLine("D = OLIVERSS");

                    ConsoleKeyInfo info = Console.ReadKey();
                    if (info.Key == ConsoleKey.A)
                    {
                        Thread.Sleep(100);
                        Console.Clear();
                        string PlayerB = "ÄRIK";

                        while (hp >= 0 || hp2 >= 0)
                        {

                            Console.WriteLine("A = Heavy attack");
                            Console.WriteLine("B = Quick attack");

                            string input = Console.ReadLine();

                            if (input == "a" || input == "A")
                            {
                                damage = generator.Next(25, 45);
                                Console.WriteLine(PlayerA + " heavy slams " + PlayerB + " for " + damage + " damage");
                                hp2 -= damage;                       
                                Console.WriteLine();
                                damage = generator.Next(25, 45);
                                Console.WriteLine(PlayerB + " slaps back at " + PlayerA + " for " + damage + " damage");
                                hp -= damage;
                                Console.WriteLine();
                                Console.WriteLine(PlayerA + " has " + hp + " health left");
                                Console.WriteLine(PlayerB + " has " + hp2 + " health left");
                          

                            }
                            else if (input == "b" || input == "B")
                            {
                                damage = generator.Next(10, 30);
                                Console.WriteLine(PlayerA + " drinks a readbull and quickly slap " + PlayerB + " for " + damage + " damage");
                                hp2 -= damage;
                                damage = generator.Next(10, 30);
                                Console.WriteLine(PlayerB + " slaps back at " + PlayerA + " for " + damage + " damage");
                                hp -= damage;

                                Console.WriteLine();
                                Console.WriteLine(PlayerA + " has " + hp + " health left");
                                Console.WriteLine(PlayerB + " has " + hp2 + " health left");
                                
                            }


                        }

                        Console.ReadLine();

                    

                    }
                    else if (info.Key == ConsoleKey.B)
                    {
                        Thread.Sleep(100);
                        Console.Clear();
                        string PlayerB = "Robino";

                        while (hp >= 0 || hp2 >= 0)
                        {

                            Console.WriteLine("A = Heavy attack");
                            Console.WriteLine("B = Quick attack");

                            string input = Console.ReadLine();

                            if (input == "a" || input == "A")
                            {
                                damage = generator.Next(25, 45);
                                Console.WriteLine(PlayerA + " heavy slams " + PlayerB + " for " + damage + " damage");
                                hp2 -= damage;
                                Console.WriteLine();
                                damage = generator.Next(25, 45);
                                Console.WriteLine(PlayerB + " slaps back at " + PlayerA + " for " + damage + " damage");
                                hp -= damage;
                                Console.WriteLine();
                                Console.WriteLine(PlayerA + " has " + hp + " health left");
                                Console.WriteLine(PlayerB + " has " + hp2 + " health left");

                            }
                            else if (input == "b" || input == "B")
                            {
                                damage = generator.Next(10, 30);
                                Console.WriteLine(PlayerA + " drinks a readbull and quickly slap " + PlayerB + " for " + damage + " damage");
                                hp2 -= damage;
                                damage = generator.Next(10, 30);
                                Console.WriteLine(PlayerB + " slaps back at " + PlayerA + " for " + damage + " damage");
                                hp -= damage;

                                Console.WriteLine();
                                Console.WriteLine(PlayerA + " has " + hp + " health left");
                                Console.WriteLine(PlayerB + " has " + hp2 + " health left");
                            }


                        }

                        Console.ReadLine();

                    
                    }
                    else if (info.Key == ConsoleKey.C)
                    {
                        Thread.Sleep(100);
                        Console.Clear();
                        string PlayerB = "Roberto";

                        while (hp >= 0 || hp2 >= 0)
                        {

                            Console.WriteLine("A = Heavy attack");
                            Console.WriteLine("B = Quick attack");

                            string input = Console.ReadLine();

                            if (input == "a" || input == "A")
                            {
                                damage = generator.Next(25, 45);
                                Console.WriteLine(PlayerA + " heavy slams " + PlayerB + " for " + damage + " damage");
                                hp2 -= damage;
                                Console.WriteLine();
                                damage = generator.Next(25, 45);
                                Console.WriteLine(PlayerB + " slaps back at " + PlayerA + " for " + damage + " damage");
                                hp -= damage;
                                Console.WriteLine();
                                Console.WriteLine(PlayerA + " has " + hp + " health left");
                                Console.WriteLine(PlayerB + " has " + hp2 + " health left");

                            }
                            else if (input == "b" || input == "B")
                            {
                                damage = generator.Next(10, 30);
                                Console.WriteLine(PlayerA + " drinks a redbull and quickly slaps " + PlayerB + " for " + damage + " damage");
                                hp2 -= damage;
                                damage = generator.Next(10, 30);
                                Console.WriteLine(PlayerB + " slaps back at " + PlayerA + " for " + damage + " damage");
                                hp -= damage;

                                Console.WriteLine();
                                Console.WriteLine(PlayerA + " has " + hp + " health left");
                                Console.WriteLine(PlayerB + " has " + hp2 + " health left");
                            }


                        }

                        Console.ReadLine();
                   
                    }
                    else if (info.Key == ConsoleKey.D)
                    {
                        Thread.Sleep(100);
                        Console.Clear();
                        string PlayerB = "OLIVERSS";

                        while (hp >= 0 || hp2 >= 0)
                        {

                            Console.WriteLine("A = Heavy attack");
                            Console.WriteLine("B = Quick attack");

                            string input = Console.ReadLine();

                            if (input == "a" || input == "A")
                            {
                                damage = generator.Next(25, 45);
                                Console.WriteLine(PlayerA + " heavy slams " + PlayerB + " for " + damage + " damage");
                                hp2 -= damage;
                                Console.WriteLine();
                                damage = generator.Next(25, 45);
                                Console.WriteLine(PlayerB + " slaps back at " + PlayerA + " for " + damage + " damage");
                                hp -= damage;
                                Console.WriteLine();
                                Console.WriteLine(PlayerA + " has " + hp + " health left");
                                Console.WriteLine(PlayerB + " has " + hp2 + " health left");
                       
                            }
                            else if (input == "b" || input == "B")
                            {
                                damage = generator.Next(10, 30);
                                Console.WriteLine(PlayerA + " drinks a readbull and quickly slap " + PlayerB + " for " + damage + " damage");
                                hp2 -= damage;
                                damage = generator.Next(10, 30);
                                Console.WriteLine(PlayerB + " slaps back at " + PlayerA + " for " + damage + " damage");
                                hp -= damage;

                                Console.WriteLine();
                                Console.WriteLine(PlayerA + " has " + hp + " health left");
                                Console.WriteLine(PlayerB + " has " + hp2 + " health left");
                          
                        }

                            if (hp >= 0)
                        {
                            Console.WriteLine("You won");
                        }

                            if (hp2 >= 0)
                        {
                            Console.WriteLine("You lost");
                        }
                                
                        
                    }
                        Console.ReadLine();                       
                    }
                

                Console.WriteLine("Wanaa play again?");
                Console.WriteLine("Yes or No");

                replay = Console.ReadLine();
                Thread.Sleep(1500);
                Console.Clear();
                                             
                }

                if (replay.ToLower() == "no")
            {
                Console.WriteLine("Well have fun");
                Thread.Sleep(1000);
                Console.Clear();
            }

                Console.ReadLine();         
            
        }
    }
}
