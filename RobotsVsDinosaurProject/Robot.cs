using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class Robot
    {
        Weapon newWeapon = new Weapon();
        
        /// will contain
        /// name
        public string name;
        /// health
        public int health;
        /// power level
        public int powerLevel;
        public int attackPower;
        public string type;
        /// 
        ///instantiate three robot objects and assing there appropriate values
        ///robot objects stored in the fleet
        ///robot can attack dino on the battlefield
        ///robot will loose health points based on dino attack power
        public Robot(string name)
        {
            this.name = name;
            this.health = 100;
            this.powerLevel = 100;
            newWeapon.plasmaBlaster();
            attackPower = newWeapon.attackPower;
            type = newWeapon.type;

        }
        public void RobotAttributesInFight()
        {
            Console.WriteLine("The robot's name is : " + name);
            Console.WriteLine("The robot's health is : " + this.health);
            Console.WriteLine("The robot's Power Level is: " + this.powerLevel);
            Console.WriteLine("The robot is using a " + newWeapon.type + " for a weapon.");
            Console.WriteLine("The weapons attack ability is : " + newWeapon.attackPower);
            Console.ReadLine();
        }

    }
}
