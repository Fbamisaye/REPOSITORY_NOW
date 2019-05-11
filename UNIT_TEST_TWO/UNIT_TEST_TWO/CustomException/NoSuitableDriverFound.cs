using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIT_TEST_TWO.Con_figuration;

namespace UNIT_TEST_TWO.CustomException
{
  public  class NoSuitableDriverFound : Exception

    {

      
        //public  NoSuitableDriverFound(string message, BrowserTypes getBrowser) : base(message)


        public NoSuitableDriverFound(string message, BrowserTypes getBrowser): base(message)
        {
            
        }
    }
}
