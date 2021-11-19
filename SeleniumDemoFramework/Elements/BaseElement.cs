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
        /// <summary>
        /// Returns the enabled or disabled state of an element
        /// </summary>
        /// <returns></returns>
        public virtual bool Enabled()
        {
            return _element.Enabled;
        }
        /// <summary>
        /// Returns if the element contains text inside
        /// </summary>
        /// <returns></returns>
        public virtual bool HasText()
        {
            return !string.IsNullOrEmpty(_element?.Text);
        }
        /// <summary>
        /// Returns whether element can be clicked
        /// </summary>
        /// <returns></returns>
        public virtual bool IsClickable()
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
        /// <summary>
        /// Returns whether the element is displayed on the web page
        /// </summary>
        /// <returns></returns>
        public virtual bool IsDisplayed()
        {
            return _element.Displayed;
        }
        /// <summary>
        /// Checks whether there are more than one element specified
        /// </summary>
        /// <returns></returns>
        public virtual bool MoreThanOne()
        {
            return _driver.FindElements(By.TagName(_element.TagName)).Any();
        }
    }
}
