using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIT_TEST_TWO.Settings;

namespace UNIT_TEST_TWO.ComponentHelper
{
    public class PageTitleHelper

    {
        public static string GetPageTitle()
        {
            var driverTitle = ObjectRepository.Driver.Title;
            return driverTitle;


        }
    }
}