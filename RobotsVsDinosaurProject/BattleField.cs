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
        Robot newRobot;
        public Fleet newFleet;
        public Herd newHerd;
        public BattleField()
        {

            newHerd = new Herd();
            newFleet = new Fleet();
            AttackPhase();
        }
        // RIGHT NOW DINO ALWAYS ATTACKS FIRST !
        // AND INDEX FROM EACH HEARD FIGHT EACH OTHER FIRST
        // WOULD BE MORE FUN IF RANDOM ATTACK


        public void AttackPhase()
        {
            int robotStarting = 0;
            int dinoStarting = 0;
            while (robotStarting <= newFleet.newRobotList.Count()- 1 || dinoStarting <= newHerd.newDinosaurList.Count() - 1)
            {

            newDinosaur = newHerd.newDinosaurList[dinoStarting];
            newRobot = newFleet.newRobotList[robotStarting];
            newDinosaur.DinoAttributesInFight();
            newRobot.RobotAttributesInFight();
            while (newDinosaur.health > 0 && newRobot.health > 0)
            {
                if ( newDinosaur.health > 0)
                {
                  DinoAttack();
                }
                if ( newRobot.health > 0)
                {
                  RobotAttack();
                }
            }
            if(newDinosaur.health <= 0 )
            {
                Console.WriteLine("The battle is over. The "+ newDinosaur.type + " has been killed!");
                newHerd.newDinosaurList.Remove(newDinosaur);
                dinoStarting++;
            }
            else if(newRobot.health <= 0)
            {
                Console.WriteLine("The battle is over. The robot named " + newRobot.name + " has been killed!");
                newFleet.newRobotList.Remove(newRobot);
                robotStarting++;
            }

            // dino attacks first
            // causes damage to robot
            // robot attacks next
            // once health is at zero, a winner is declared
            // the looser is removed from herd
            // the winners attributes have to be saved to fight next enemy
            }
        }
        public void DinoAttack()
        {
            newRobot.health -= newDinosaur.attackPower;
            Console.WriteLine("The " + newDinosaur.type + " has attacked causing " + newDinosaur.attackPower + " damage to the robot.");
            newRobot.RobotAttributesInFight();
        }
        public void RobotAttack()
        {
            newDinosaur.health -= newRobot.attackPower;
            Console.WriteLine("The robot " + newRobot.name + " has attacked causing " + newRobot.attackPower + " damage to the Dinosaur.");
            newDinosaur.DinoAttributesInFight();
        }
    }
}
