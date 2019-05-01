using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using FolaBami2019Sol.Child;
using FolaBami2019Sol.Grandparent;
using FolaBami2019Sol.Parent;
using FolaBami2019Sol.Static_Things;

namespace FolaBami2019Sol
{
	  public  class Program
	{

        static void Main(string[] args)

        {
            //ChildClass childClass = new ChildClass();
            //childClass.CallMyBankDetails();
            //childClass.DeclareMyBankingDetails();

            CallContructor callconstructor = new CallContructor("Cat", 2, 4);
            callconstructor.CreateAnimal();

            Console.WriteLine("------");
            CallContructor callconstructorNew = new CallContructor("Dragon", 2, 4, 1);
            callconstructorNew.CreateAnimal();
           


            Console.ReadKey();




           

        }

          








        }


        }
    
