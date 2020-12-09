using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class Dinosaur
    {
        private Random newRandom;
        public int dino;
        public string type;
        public double health;
        public int energy;
        public double attackPower;
        public Dinosaur()
        {
            this.health = 100;
            newRandom = new Random();
            dino = newRandom.Next(1, 4);
            ConstructDino();
        }
        public void ConstructDino()
        {
            if (dino == 1)
            {
                FlyingDino();
            }
            else if (dino == 2)
            {
                SwimmingDino();
            }
            else
            {
                WalkingDino();
            }

        }

        public void FlyingDino()
        {
            energy = newRandom.Next(50, 100);
            attackPower = newRandom.Next(20, 100);
            type = "Flying Pterosaurs";
        }
        public void SwimmingDino()
        {
            energy = newRandom.Next(90, 100);
            attackPower = newRandom.Next(20, 100);
            type = "Swimming Spinosaurus";
        }
        public void WalkingDino()
        {
            energy = newRandom.Next(70, 100);
            attackPower = newRandom.Next(20, 100);
            type = "Walking Achillobator";
        }
        public void DinoAttributesInFight()
        {

            Console.WriteLine("The Dinosaur you are facing is a : " + this.type + "\n");
            Console.Write("The Dinosaur's health is:          ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" " + this.health);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("The Dinosaur's energy level is:     ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" " + this.energy);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("The Dinosaur has an attack power of:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" " + this.attackPower);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

    }
}
