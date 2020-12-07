using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class BattleField
    {
        Dinosaur newDinosaur;
        Weapon newWeapon;
        Fleet newFleet;
        Herd newHerd;
        public BattleField()
        {
            newHerd = new Herd();
            newFleet = new Fleet();
            newDinosaur = new Dinosaur();
            
        }
        // RIGHT NOW DINO ALWAYS ATTACKS FIRST !
        // AND INDEX FROM EACH HEARD FIGHT EACH OTHER FIRST
        // WOULD BE MORE FUN IF RANDOM ATTACK


        public void AttackPhase()
        {
            Console.WriteLine("Prepair for battle !!!!!! ");
            Console.Write(newDinosaur.type + newDinosaur.attackPower + newDinosaur.energy);
        }
    }
}
