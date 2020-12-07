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
        string type;
        /// health
        int health;
        /// energy
        int energy;
        /// attack power
        int attackPower;
        /// 
        /// instantiate three dinosaur objects and assign the appropriate values to all the objects
        /// dinosaur objects will be stored in a Herd
        /// Ability to attack a robot on the battelfield
        /// dinosaur will loose health points based on attak power of robot
        public Dinosaur()
        {
            dino = newRandom.Next(1, 4);
            this.health = 100;
            if ( dino == 1)
            {
                flyingDino();
            }
            else if ( dino == 2)
            {
                swimmingDino();
            }
            else
            {
                walkingDino();
            }
        }
        public void flyingDino()
        {
            energy = newRandom.Next(50, 100);
            attackPower = newRandom.Next(80, 100);
            
        }
        public void swimmingDino()
        {
            energy = newRandom.Next(90, 100);
            attackPower = newRandom.Next(90, 100);
        }
        public void walkingDino()
        {
            energy = newRandom.Next(70, 100);
            attackPower = newRandom.Next(85, 100);
        }
    }
}
