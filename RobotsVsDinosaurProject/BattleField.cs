using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class BattleField
    {
        Robot newRobot;
        Dinosaur newDinosaur;
        Weapon newWeapon;
        Fleet newFleet;
        Herd newHerd;
        public BattleField()
        {
            newHerd = new Herd();
            newFleet = new Fleet();
            
        }
        // RIGHT NOW DINO ALWAYS ATTACKS FIRST !
        // AND INDEX FROM EACH HEARD FIGHT EACH OTHER FIRST
        // WOULD BE MORE FUN IF RANDOM ATTACK


        public void AttackPhase(Herd dinoFighting, Fleet roboFighting)
        {
            int robotStarting = 0;
            int dinoStarting = 0;
            newDinosaur = dinoFighting.newDinosaurList[dinoStarting];
            newRobot = roboFighting.newRobotList[robotStarting];
            // takes a dino and robot and makes them fight each other.

            // dino attacks first
            // causes damage to robot
            // robot attacks next
            // once health is at zero, a winner is declared
            // the looser is removed from herd
            // the winners attributes have to be saved to fight next enemy
        }
    }
}
