using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class Weapon
    {
        readonly Random newRandom2 = new Random();
        public int attackPower;
        public string type;
        public void plasmaBlaster()
        {
            this.attackPower = newRandom2.Next(40, 100);
            this.type = "Plasma Blaster";
        }
    }
}
