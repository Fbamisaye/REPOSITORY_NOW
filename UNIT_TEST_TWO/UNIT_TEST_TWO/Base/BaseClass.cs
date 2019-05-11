using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using UNIT_TEST_TWO.Configuration;
using UNIT_TEST_TWO.Con_figuration;
using UNIT_TEST_TWO.CustomException;
using UNIT_TEST_TWO.Settings;

namespace UNIT_TEST_TWO.Base
{

    [TestClass]
    public class BaseClass

    {
        private static  IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;

        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;

        }


        private static IWebDriver GetIExplorerDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;

        }



        [AssemblyInitialize]

        public static  void InitWebDriver(TestContext testContext)
        {
            ObjectRepository.Config1 = new AppConfigReader();

            switch (ObjectRepository.Config1.GetBrowser())
            {
                case BrowserTypes.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;

                case BrowserTypes.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                case BrowserTypes.IExplorer:
                    ObjectRepository.Driver = GetIExplorerDriver();
                    break;

                default:
                    throw NoSuitableDriverFound("Driver not found {0}", ObjectRepository.Config1.GetBrowser());
            }
        }

        [AssemblyCleanup]
        public static void TearDown()
        {
            if (ObjectRepository.Driver!= null)
            {
                //ObjectRepository.Driver.Quit();
                ObjectRepository.Driver.Close();
                //ObjectRepository.Driver.Dispose();
            }

        }





        private static Exception NoSuitableDriverFound(string v, BrowserTypes browserTypes)
        {
            throw new NotImplementedException();
        }
    }

}
