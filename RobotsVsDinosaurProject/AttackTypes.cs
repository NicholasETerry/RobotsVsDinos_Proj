using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class AttackTypes
    {
        Dinosaur newDinosaur;
        public AttackTypes()
        {
            newDinosaur = new Dinosaur();

        }
        public void BreathFire()
        {
            newDinosaur.attackPower += 20;
        }
        public void WhipLash()
        {
            newDinosaur.attackPower += 10;
        }
        public void Trample()
        {
            newDinosaur.attackPower += 40;
        }
    }
}
