using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class Weapon
    {
        int hitOnHealth;
        int energyReduced;
        int attackPowerReduced;
        public void plasmaBlaster()
        {
            hitOnHealth = 20;
            energyReduced = 10;
            attackPowerReduced = 5;
        }
    }
}
