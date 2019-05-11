using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UNIT_TEST_TWO.Configuration;
using UNIT_TEST_TWO.Interfaces;

namespace UNIT_TEST_TWO.Settings
{
    public class ObjectRepository


    {
        //public  static IConfig Config { get; set; }

        //public static  IWebDriver Driver { get; set; }

        public static ICongfig Config1 { get; set; }
        public static IWebDriver Driver { get; set; }


    }
}
