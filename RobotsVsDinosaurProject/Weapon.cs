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
        string type;
        public void plasmaBlaster()
        {
            this.attackPower = newRandom.Next(40, 100);
            this.type = "Plasma Blaster";
        }
    }
}
