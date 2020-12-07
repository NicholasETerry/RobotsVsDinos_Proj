using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class Robot
    {
        Random newRandom = new Random();
        
        /// will contain
        /// name
        string name;
        /// health
        int health;
        /// power level
        int powerLevel;
        /// weapon with a type ( sword or gun or knife...)
        string weapon ;
        /// attack power
        int attackPower;
        /// 
        ///instantiate three robot objects and assing there appropriate values
        ///robot objects stored in the fleet
        ///robot can attack dino on the battlefield
        ///robot will loose health points based on dino attack power
        public Robot(string name)
        {
            this.health = 100;
            this.powerLevel = newRandom.Next(40, 100);
            this.weapon = "Plasma Blaster";
            this.attackPower = 100;
        }
    }
}
