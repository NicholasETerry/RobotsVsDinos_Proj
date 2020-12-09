using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class Fleet
    {
        Weapon newWeapon;
        public List<Robot> newRobotList;
        public Fleet()
        {
            newWeapon = new Weapon();
            newRobotList = new List<Robot>();
            newRobotList.Add(new Robot("Dave"));
            newRobotList.Add(new Robot("Charlie"));
            newRobotList.Add(new Robot("Erwin"));
        }
    }
}
