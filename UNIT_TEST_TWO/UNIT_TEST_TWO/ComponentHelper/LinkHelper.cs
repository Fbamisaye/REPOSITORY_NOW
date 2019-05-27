using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UNIT_TEST_TWO.ComponentHelper
{
   public class LinkHelper


   {
       private static IWebElement element;

       public static void ClickLink(By locator)
       {
           element = GeneraicHelper.GetWebElement(locator);
           element.Click();
       }



   }
}
