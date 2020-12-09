using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class Weapon
    {
        private Random newRandom;
        public double attackPower;
        public string type;
        public Weapon()
        {
            newRandom = new Random();
            GiveRobotTheWeapon();
        }
        public void PlasmaBlaster()
        {
            this.attackPower = newRandom.Next(10, 60);
            this.type = "Plasma Blaster";
        }
        public void ElectroMagneticPulseCannon()
        {
            this.attackPower = newRandom.Next(50, 100);
            this.type = "Electro Magnetic Pulse Cannon";
        }
        public void TriBladeScalper()
        {
            this.attackPower = newRandom.Next(5, 50);
            this.type = "Triblade Scalper";
        }
        public void GiveRobotTheWeapon()
        {
            int getWeapon = newRandom.Next(1, 301);
            if( getWeapon < 101)
            {
                PlasmaBlaster();
            }
            else if(getWeapon >= 101 && getWeapon < 201)
            {
                TriBladeScalper();
            }
            else if (getWeapon > 200)
            {
                ElectroMagneticPulseCannon();
            }
        }
    }
}
