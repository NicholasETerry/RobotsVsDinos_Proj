using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class Fleet
    {
        public List<Robot> newRobotList = new List<Robot>();
        Robot newRobot1;
        Robot newRobot2;
        Robot newRobot3;
        public Fleet()
        {

            newRobotList.Add(new Robot("Dave"));
            newRobotList.Add(new Robot("Charlie"));
            newRobotList.Add(new Robot("Erwin"));
        }
        public void FleetInBattle()
        {

        }
    }
}
