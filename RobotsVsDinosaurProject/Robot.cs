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
        public string name;
        /// health
        public int health;
        /// power level
        public int powerLevel;
        /// 
        ///instantiate three robot objects and assing there appropriate values
        ///robot objects stored in the fleet
        ///robot can attack dino on the battlefield
        ///robot will loose health points based on dino attack power
        public Robot(string name)
        {
            this.health = 100;

            this.powerLevel = 100;
        }

    }
}
