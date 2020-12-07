using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class Weapon
    {
        Random newRandom = new Random();
        int attackPower;
        string weapon;
        public void plasmaBlaster()
        {
            this.attackPower = newRandom.Next(40, 100);
            this.weapon = "Plasma Blaster";
        }
    }
}
