using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class Herd
    {
        public List<Dinosaur> newDinosaurList;
        public Herd()
        {
            newDinosaurList = new List<Dinosaur>();
            PopulateList();
        }
        public void PopulateList()
        {
            newDinosaurList.Add(new Dinosaur());
            newDinosaurList.Add(new Dinosaur());
            newDinosaurList.Add(new Dinosaur());
        }
    }

}
