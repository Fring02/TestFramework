using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoFramework.Elements
{
    public abstract class BaseElement
    {
        protected IWebDriver _driver;
        protected IWebElement _element;
        protected BaseElement(IWebDriver driver)
        {
            _driver = driver;
        }
        public bool Enabled()
        {
            return _element.Enabled;
        }
        public bool HasText()
        {
            return !string.IsNullOrEmpty(_element?.Text);
        }
        public bool IsClickable()
        {
            try
            {
                _element.Click();
            } catch
            {
                return false;
            }
            return false;
        }
        public bool IsDisplayed()
        {
            return _element.Displayed;
        }

        public bool MoreThanOne()
        {
            return _driver.FindElements(By.TagName(_element.TagName)).Any();
        }
    }
}
