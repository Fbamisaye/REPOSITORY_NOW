using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UNIT_TEST_TWO.ComponentHelper;
using UNIT_TEST_TWO.Settings;

namespace UNIT_TEST_TWO.SandBox.WebElementts
{
    [TestClass]

   public class TestWebElements

    {
        [TestMethod]
        public  void Elements()
        {
            NavigationHelper.
                NavigateToUrl(ObjectRepository.
                    Config1.
                    GetWebsite());
            try
            {
              


            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
                throw;
            }

            //var tagList = ObjectRepository.Driver.FindElements(By.TagName("input"));

            //foreach (var tag in tagList)
            //{

            //    {
            //        if (!tag.GetAttribute("value").Equals("Go")) continue;
            //        tag.Click();
            //        break;

            //    }

            //LinkHelper.ClickLink(By.LinkText("Learn more about sponsorship"));
            LinkHelper.ClickLink(By.PartialLinkText("more about sponsorship"));

            TextBoxHelper.ClearText(By.Id(""));



        }

        }

    }

