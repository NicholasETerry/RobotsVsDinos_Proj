using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class BattleField
    {
        AttackTypes newTypes;
        Weapon newWeapon;
        Dinosaur newDinosaur;
        Robot newRobot;
        public Fleet newFleet;
        public Herd newHerd;
        public BattleField()
        {

            newTypes = new AttackTypes();
            newWeapon = new Weapon();
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
                        Console.WriteLine("Choose an attack type.\n" +
                            "press W for Whiplash\n" +
                            "press B for BreathFire\n" +
                            "press T for Trample");
                        if(Console.ReadKey().Key == ConsoleKey.W)
                        {
                            newTypes.WhipLash();
                        }
                        else if(Console.ReadKey().Key == ConsoleKey.B)
                        {
                            newTypes.BreathFire();
                        }
                        else if(Console.ReadKey().Key == ConsoleKey.T)
                        {
                            newTypes.Trample();
                        }
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
            Console.WriteLine("The " + newDinosaur.type + " has attacked causing " + newDinosaur.attackPower + " damage to the robot.\n");
            newDinosaur.energy -= 10;
            newDinosaur.attackPower *= .90;
            newDinosaur.DinoAttributesInFight();
        }
        public void RobotAttack()
        {
            newDinosaur.health -= newRobot.attackPower;
            Console.WriteLine("The robot " + newRobot.name + " has attacked causing " + newRobot.attackPower + " damage to the Dinosaur.\n");
            newRobot.powerLevel -= 10;
            newWeapon.attackPower *= .90; 
            newRobot.RobotAttributesInFight();
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
