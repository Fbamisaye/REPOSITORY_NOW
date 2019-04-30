using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FolaBami2019Sol
{
    public class PriMeth


    {
        private int studentAge;
        private string studentName;
        protected int Money;
        private int _NumberOne =2;
        private int _NumberTwo =4;

        public void studentDetails (int age, string name)
        {
            studentAge = age;
            studentName =name;
            Console.WriteLine( "{0} is {1} years old ", studentName, studentAge);
            Console.WriteLine(" my private calculation is {0} ", multiplyMe(5, 3));
        }

        private int multiplyMe(int numA, int numB)
        {
            _NumberOne = numA;
            _NumberTwo = numB;
            int result = numA * numB;
            return result;
        }
        internal void studentSomething()
        {
            Console.WriteLine(studentAge);
            Console.WriteLine(studentName);
            Console.WriteLine("{0} is in my money", Money );
        }


    }

  
   

   
   
    
}
