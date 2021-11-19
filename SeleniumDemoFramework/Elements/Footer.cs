using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoFramework.Elements
{
    public class Footer : BaseElement
    {
        public Footer(IWebDriver driver) : base(driver)
        {
            _element = _driver.FindElement(By.TagName("footer"));
        }

        public bool IsFixed()
        {
            try
            {
                return _element.GetCssValue("position") == "fixed";
            }
            catch
            {
                return false;
            }
        }

        public bool HasContacts()
        {
            try
            {
                return _element.FindElements(By.ClassName("contacts")).Any();
            } catch
            {
                return false;
            }
        }
    }
}
