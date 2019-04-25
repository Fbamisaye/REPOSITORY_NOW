using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace FolaBami2019Sol
{
	class Program
	{
        

        //this is single line comment and this is the main method
        static void Main(string[] args)

		{
			Console.WriteLine("Hello class of 2019");

            /*
			 * this is a multiline comment
			 * the following are data types in c#
			 * the building blocks of codes
			  */

            // datatype(e.g-string,int) with variables value:

            int age = 55;
            char alphabet = 'c';
            string name = "dimeji5000";
            double bankbalance = 250000000;
          //DateTime.Today;
            bool statevalue = true;

            Console.WriteLine("my age is " +  age);
			Console.WriteLine("the first letter of my name is" + alphabet);
			Console.WriteLine("my name is " +  name);
			Console.WriteLine(bankbalance);
			Console.WriteLine("i am a  man "+ statevalue);
            
            Console.WriteLine(DateTime.Now);
			Console.ReadKey();

        }
    }
}
