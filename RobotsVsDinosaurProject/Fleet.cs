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
        Robot newRobot1 = new Robot("Dave");
        Robot newRobot2 = new Robot("Charlie");
        Robot newRobot3 = new Robot("Erwin");
        public Fleet()
        {

            newRobotList.Add(newRobot1);
            newRobotList.Add(newRobot2);
            newRobotList.Add(newRobot3);
        }
    }
}
