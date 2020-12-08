using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class Dinosaur
    {

        readonly Random newRandom;
        readonly Random newRandomEnergy;
        readonly Random newRandomAttackPower;
        public int dino;
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        public Dinosaur()
        {
            this.health = 100;
            newRandom = new Random();
            newRandomEnergy = new Random();
            newRandomAttackPower = new Random();
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
            energy = newRandomEnergy.Next(50, 100);
            attackPower = newRandomAttackPower.Next(20, 100);
            type = "Flying Pterosaurs";
        }
        public void SwimmingDino()
        {
            energy = newRandomEnergy.Next(90, 100);
            attackPower = newRandomAttackPower.Next(20, 100);
            type = "Swimming Spinosaurus";
        }
        public void WalkingDino()
        {
            energy = newRandomEnergy.Next(70, 100);
            attackPower = newRandomAttackPower.Next(20, 100);
            type = "Walking Achillobator";
        }
        public void DinoAttributesInFight()
        {
            Console.WriteLine("The Dinosaur you are facing is a : " + this.type);
            Console.WriteLine("The Dinosaur's health is: " + this.health);
            Console.WriteLine("The Dinosaur's energy level is : " + this.energy);
            Console.WriteLine("The Dinosaur has an attack power of : " + this.attackPower);
            Console.ReadLine();
        }

    }
}
