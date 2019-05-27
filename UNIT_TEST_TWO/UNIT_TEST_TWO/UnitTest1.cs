using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UNIT_TEST_TWO.ComponentHelper;
using UNIT_TEST_TWO.Con_figuration;
using UNIT_TEST_TWO.Configuration;
using UNIT_TEST_TWO.Interfaces;
using UNIT_TEST_TWO.Settings;

namespace UNIT_TEST_TWO
{
    [TestClass]
    public class UnitTest1
    {
        //private readonly ICongfig _config = new AppConfigReader();

        //[TestMethod, TestCategory("SmokeTest")]
        
        //public void LaunchBrowserAndCloseBrowser()

        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Navigate().GoToUrl("https://kress2m1.github.io/prog-mine.html");
        //    driver.FindElement(By.LinkText("Automation Course")).Click();
        //    driver.Close();
        //    //driver.Quit();
        //    driver.Dispose();

        //}

        //[TestMethod, TestCategory("SmokeTest")]

        //public void Navigate()

        //{
        //    ConfigurationManager.AppSettings.Get("Browser");
        //    Console.WriteLine(BrowserTypes.Chrome);
        //    Console.WriteLine((int)BrowserTypes.Explorer);
        //}

        [TestMethod]
        public void SimpleMethod()
        {

            NavigationHelper.
                NavigateToUrl(ObjectRepository.
                    Config1.
                    GetWebsite());

            //object pageTitle = PageTitleHelper.GetPageTitle();
            Console.WriteLine("the page title is: {0}", PageTitleHelper.GetPageTitle());
          

        }



    }
}
