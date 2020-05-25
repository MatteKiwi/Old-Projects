using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klass_övning
{
    class Program
    {
        static void Main(string[] args)
        {

            

        }
    }

    class Location
    {
        public float X = 2;
        public float Y = 3;
        public float Z = 4;

    }

    class Ball
    {
        public int currentLocation = 4;
        public int newLocation = 6;
        public int speed = 2;
            
    }

    class Potions
    {
        public string nameHealth = "Health Potion";
        public string nameMana = "Mana Potion";

        public int Mana = 150;
        public int Health = 100;

    }

    class DragonAgeSword
    {
        public string swordName = "GOD SWORD";
        public int dmg = 100;
        public int durability = 300;
    } 
}
