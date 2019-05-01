using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolaBami2019Sol
{
   public class ConstructMe

   {
       protected string Species;
       protected int numberOfEyes;
       protected int numberOfLegs;
       protected int numberOftail;
       //public ConstructMe()
       //{

           
       //}

       public ConstructMe(string animalType, int eyes, int legs)
       {
           Species = animalType;
           numberOfEyes = eyes;
           numberOfLegs = legs;
           Console.WriteLine("A {0}  has {1} eyes  & {2}legs ", Species, numberOfEyes, numberOfLegs);
        }

       public ConstructMe(string animalType, int eyes, int legs, int tail)
       {

            Species = animalType;
            numberOfEyes = eyes;
            numberOfLegs = legs;
            numberOftail = tail;
            Console.WriteLine("A {0}  has {1} eyes  & {2}of tails & {3}legs ",
                Species, numberOfEyes, numberOfLegs, numberOftail);

        }


    }
}
