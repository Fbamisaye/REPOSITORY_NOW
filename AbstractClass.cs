using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolaBami2019Sol
{
  public  abstract class AbstractClass

  {
      private int paramOne;
      private int paramTwo;
      protected double addResult;

      public void AdditionResult()
      {
          Console.WriteLine("Addition of {0} and {1} is: {2}", paramOne, paramTwo, addResult);
      }

      public abstract void AddMe(int numOne, int numTwo);
  }
}
