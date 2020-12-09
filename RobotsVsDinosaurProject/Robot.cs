using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class Robot
    {
        Weapon newWeapon;
        public string name;
        public double health;
        public int powerLevel;
        public double attackPower;
        public string type;
        public Robot(string name)
        {
            this.name = name;
            this.health = 100;
            this.powerLevel = 100;
            newWeapon = new Weapon();
            type = newWeapon.type;
            attackPower = newWeapon.attackPower;
        }
        public void RobotAttributesInFight()
        {
            Console.WriteLine("The robot's name is :" + name + "\n");
            Console.Write("The robot's health is :");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" " + this.health);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("The robot's Power Level is:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" " + this.powerLevel);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The robot is using a " + newWeapon.type + " for a weapon.");
            Console.Write("The weapons attack ability is :");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" " + newWeapon.attackPower);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

    }
}
