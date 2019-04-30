using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolaBami2019Sol
{
   public class Triangle


   {
       public int triheight;
       public int triBase;
       public int areaAnswer;
       private int _something;

       public void TriangleArea()
       {
           areaAnswer = triheight * triBase;
           Console.WriteLine(" the area of the triangle is {0} ", areaAnswer);
           Console.WriteLine();
       }



   }
}
