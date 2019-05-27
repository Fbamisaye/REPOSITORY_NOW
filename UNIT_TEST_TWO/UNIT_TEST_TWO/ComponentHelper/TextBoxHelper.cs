using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UNIT_TEST_TWO.ComponentHelper
{

  public  class TextBoxHelper


  {


      private static IWebElement element;

        public static void SendText(By locator, string text)
        {
            element = GeneraicHelper.GetWebElement(locator);
            element.SendKeys(text);
        }

        public static void ClearText(By locator)
        {
            element = GeneraicHelper.GetWebElement(locator);
            element.Clear();
        }


    }
}
