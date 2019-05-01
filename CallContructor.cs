using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolaBami2019Sol
{
   public class CallContructor : ConstructMe

   {
        public CallContructor(string animalType, int eyes, int legs) : base(animalType, eyes, legs)
        {
        }

        public CallContructor(string animalType, int eyes, int legs, int tail) : base(animalType, eyes, legs ,tail)
        {
        }

        public void CreateAnimal()
       {
           base.Species = "Dog";
           base.numberOfEyes = 23;
           base.numberOfLegs = 4;

           Console.WriteLine("A {0}  has {1} eyes  & {2}legs ", Species, numberOfEyes, numberOfLegs);

       }

      
        




   }
}
