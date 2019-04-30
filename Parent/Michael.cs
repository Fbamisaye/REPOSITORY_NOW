using FolaBami2019Sol.Grandparent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolaBami2019Sol.Parent
{
   public class Michael : Kay


   {
       protected string ParentName = "Michael";
       protected int parentAge = 45;


       protected void FatherName()
       {
           Console.WriteLine("my dad's name is {0}", ParentName);
       }

       protected void FatherAge()
       {
           Console.WriteLine("He is {0} years old ", parentAge);
       }


    }
}
