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
            EndOfAttack();
        }
        public void AttackPhase()
        {
            int robotStarting = newFleet.newRobotList.Count() - 1;
            int dinoStarting = newHerd.newDinosaurList.Count() - 1;
            while (robotStarting > -1 && dinoStarting > -1)
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nThe battle is over. The "+ newDinosaur.type + " has been killed!\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    newHerd.newDinosaurList.Remove(newDinosaur);
                dinoStarting = newHerd.newDinosaurList.Count - 1;
            }
            else if(newRobot.health <= 0)
            {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nThe battle is over. The robot named " + newRobot.name + " has been killed!\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    newFleet.newRobotList.Remove(newRobot);
                robotStarting = newFleet.newRobotList.Count - 1;
            }
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
        public void EndOfAttack()
        {
            if(newHerd.newDinosaurList.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nALL THE DINOSAURS ARE DEAD ! ");
            }
            else if (newFleet.newRobotList.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nALL THE ROBOTS ARE DEAD ! ");
            }
        }
    }
}
