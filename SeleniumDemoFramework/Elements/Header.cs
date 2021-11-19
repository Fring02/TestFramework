using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoFramework.Elements
{
    public class Header : BaseElement
    {
        public Header(IWebDriver driver) : base(driver)
        {
           _element = driver.FindElement(By.TagName("header"));
        }

        /// <summary>
        /// Checks whether the header contains navbar
        /// </summary>
        /// <returns></returns>
        public bool ContainsNavbar()
        {
            try
            {
              _element.FindElement(By.TagName("nav"));
            } catch
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Checks whether the header has fixed position
        /// </summary>
        /// <returns></returns>
        public bool IsFixed()
        {
            try
            {
                return _element.GetCssValue("position") == "fixed";
            } catch
            {
                return false;
            }
        }

    }
}
