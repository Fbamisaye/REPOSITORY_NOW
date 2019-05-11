using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIT_TEST_TWO.Con_figuration;

namespace UNIT_TEST_TWO.Interfaces
{
  public  interface ICongfig

  {
      string GetUserName();

      string GetPassword();

      BrowserTypes GetBrowser();

      string GetWebsite();

  }
}
