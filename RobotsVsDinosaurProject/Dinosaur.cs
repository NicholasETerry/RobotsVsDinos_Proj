using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class Dinosaur
    {

        Random newRandom = new Random();
        int dino;
        /// type
        public string type;
        /// health
        public int health;
        /// energy
        public int energy;
        /// attack power
        public int attackPower;
        /// 
        /// instantiate three dinosaur objects and assign the appropriate values to all the objects
        /// dinosaur objects will be stored in a Herd
        /// Ability to attack a robot on the battelfield
        /// dinosaur will loose health points based on attak power of robot
        public Dinosaur()
        {
            this.health = 100;
            ConstructDino();
        }
        public void ConstructDino()
        {
            dino = newRandom.Next(1, 4);
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
            attackPower = newRandom.Next(80, 100);
            type = "Flying Pterosaurs";
        }
        public void SwimmingDino()
        {
            energy = newRandom.Next(90, 100);
            attackPower = newRandom.Next(90, 100);
            type = "Swimming Spinosaurus";
        }
        public void WalkingDino()
        {
            energy = newRandom.Next(70, 100);
            attackPower = newRandom.Next(85, 100);
            type = "Walking Achillobator";
        }

    }
}
