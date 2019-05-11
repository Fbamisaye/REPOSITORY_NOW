using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIT_TEST_TWO.Settings;

namespace UNIT_TEST_TWO.ComponentHelper
{
   public class NavigationHelper


    {
        public static void NavigateToUrl(string url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(url);
        }
    }
}
