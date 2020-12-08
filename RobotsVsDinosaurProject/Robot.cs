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
        public string name;
        public int health;
        public int powerLevel;
        public int attackPower;
        public string type;
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
