using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolaBami2019Sol.Parent;

namespace FolaBami2019Sol.Child
{
    public   class Folake : Michael // this is now the Base class

    {

        public string childName = "Folake";
        public int childAge = 24;


        public void PickinName()
        {
            Console.WriteLine("my name is {0}", childName);
            giveMeMoney();
            
        }

        public void PickinAge()
        {
            Console.WriteLine( "I am {0} years old ", childAge);
        }

       

        public void CallDaddyName()
        {
            Console.WriteLine("my surname is {0}", ParentName);
            FatherName();
            
        }

        public void MarriedName()
        {
            ParentName = "Bamisaye";
            Console.WriteLine("my married name is {0}", ParentName);
        }

        public void CallDaddyAge()
        {
            Console.WriteLine("my daddy's age is {0}", parentAge);
            FatherAge();
        }


    }
}
