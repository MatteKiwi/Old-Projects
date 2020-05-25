using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace tre_rum
{
    class Program
    {
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        static void Main(string[] args)
        {
            int room = 0;

            string[] roomDescriptions = { "You are in the hallway", "You are in the kitchen", "You are in the garage, there is a door in the back", "The door opened, it was full of My little pony plushies, gongratz you won" };
            string[] direction = {"Go where? (North, East, South, West)"};

            while (room != 3)
            {
                
                Console.WriteLine(roomDescriptions[room]);
                Console.WriteLine(direction[0]);
                string input = Console.ReadLine();
                Thread.Sleep(100);
                Console.Clear();


                if (room == 0)
                {
                  
                    if (input.ToLower() == "north") //till köket
                    {
                        room = 1;
                    }
                    else if (input.ToLower() == "east") //till garaget 
                    {
                        room = 2;
                    }
                    else if (input.ToLower() == "south")
                    {
                        Console.WriteLine("You can't go there");
                    }
                    else if (input.ToLower() == "west")
                    {
                        Console.WriteLine("You can't go there");
                    }

                }
               else if (room == 1)
                {

                    if (input.ToLower() == "south") // till hallen
                    {
                        room = 0;
                    }
                    else if (input.ToLower() == "east") 
                    {
                        Console.WriteLine("You can't go there");
                    }
                    else if (input.ToLower() == "north")
                    {
                        Console.WriteLine("There is a book next to the window");
                        Console.WriteLine("Do you want to look at the book?");
                        string answear = Console.ReadLine();

                        if (answear.ToLower() == "yes") 
                        {

                            Console.WriteLine("You look at the book, it had a recipe open");
                            Console.WriteLine("1. Take flour");
                            Console.WriteLine("3. Beat it ");
                            Console.WriteLine("3. Yell who's your daddy");
                            Console.WriteLine("7. Put in oven and it's done");
                            Console.WriteLine("___________________________________________");
                        }
                        else if (answear != "yes" )
                        {
                            Console.WriteLine("ok");
                        }
                    }
                    else if (input.ToLower() == "west")
                    {
                        Console.WriteLine("You can't go there");
                    }
                }

                else if (room == 2)
                {
                    
                    int pinCode = 1337;
                    string code = pinCode.ToString();

                    if (input.ToLower() == "west")
                    {
                        room = 0;
                    }
                    else if (input.ToLower() == "north")
                    {                      
                        Console.WriteLine("You approched the door, there is a key pad next to it");
                        Console.WriteLine("Enter passcode");
                        code = Console.ReadLine();
                       
                      if (code == "1337")
                        {
                            room = 3;
                        }
                      else if(code != "1337")
                        {
                            Console.WriteLine("Look around");
                        }
                      
                    }
                    else if (input.ToLower() == "east")
                    {
                        Console.WriteLine("You can't go there");
                    }
                    else if (input.ToLower() == "south")
                    {
                        Console.WriteLine("You can't go there");
                    }
                }
                
                else if (room == 3)
                {                  
                    room = 3;
                }

            }

            Console.WriteLine(roomDescriptions[3]);

            Console.ReadLine();

        }
    }
}
