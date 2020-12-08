using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurProject
{
    class Herd
    {
        public List<Dinosaur> newDinosaurList = new List<Dinosaur>();
        Dinosaur newDinosaur1 = new Dinosaur();
        Dinosaur newDinosaur2 = new Dinosaur();
        Dinosaur newDinosaur3 = new Dinosaur();
        public Herd()
        {

            newDinosaurList.Add(newDinosaur1);
            newDinosaurList.Add(newDinosaur2);
            newDinosaurList.Add(newDinosaur3);
        }
    }

}
