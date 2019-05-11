using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UNIT_TEST_TWO.ComponentHelper;
using UNIT_TEST_TWO.Settings;

namespace UNIT_TEST_TWO.SandBox.Navigation
{
    [TestClass]

   public class Test_Navigation

    {
        [TestMethod]

        public void NavigateToUglyWebsite()
        {
            //INavigation page = ObjectRepository.Driver.Navigate();
            //page.GoToUrl(ObjectRepository.Config1.GetWebsite());

            //ObjectRepository.Driver.
            //    Navigate().
            //    GoToUrl(ObjectRepository.Config1.GetWebsite());

            NavigationHelper.NavigateToUrl(ObjectRepository.Config1.GetWebsite());
        }
    }
}
