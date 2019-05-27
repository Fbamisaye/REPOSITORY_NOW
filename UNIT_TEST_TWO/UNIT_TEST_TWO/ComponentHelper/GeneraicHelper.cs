using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UNIT_TEST_TWO.Settings;

namespace UNIT_TEST_TWO.ComponentHelper
{
    public class GeneraicHelper

    {
        public static bool IsElementPresent(By locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(locator).Count == 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public static IWebElement GetWebElement(By locator)
        {

            if (IsElementPresent(locator))
            {
                return ObjectRepository.Driver.FindElement(locator);
            }
            else
            {
             throw new NoSuchElementException("Element is not present " + locator.ToString());
            }

        }
      }
  }

