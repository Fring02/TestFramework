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
