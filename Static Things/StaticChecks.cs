using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolaBami2019Sol.Static_Things
{
  public    class StaticChecks


  {
      public string name;
      public int age;
      public static int staticNumber;

      public void SetValue(int paramsOne)
      {
          staticNumber = paramsOne;
      }


      public void GetValue()
      {
          Console.WriteLine("the value for the static number is {0}", staticNumber);
      }
        // this is a static method

      public static void SetStaticValue(int paramTwo)
      {
          staticNumber = paramTwo;
      }

      public static void GetStaticValue()
      {
          Console.WriteLine("the value of the static number is {0}", staticNumber);
      }
  }

}
