using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolaBami2019Sol
{
       public class Square
       {
           public int squareHeights;
           public int squareBase;
           public int areaAnswer;
           //this is the second method that is returned
           public int SqaureArea()
           {
               areaAnswer = (squareBase + squareHeights) * 2;
               Console.WriteLine("the area of the square is {0} ", areaAnswer);
               return areaAnswer;
           }
       }
}
