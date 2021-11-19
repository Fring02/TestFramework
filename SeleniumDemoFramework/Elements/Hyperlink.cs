using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoFramework.Elements
{
    public class Hyperlink : BaseElement
    {
        private IWebElement[] _elements;
        public Hyperlink(IWebDriver driver) : base(driver)
        {
            _elements = driver.FindElements(By.TagName("a")).ToArray();
        }

        public override bool Enabled()
        {
            return _elements.All(e => e.Enabled);
        }

        public override bool IsDisplayed()
        {
            return _elements.All(e => e.Displayed);
        }

        public override bool HasText()
        {
            return _elements.All(e => !string.IsNullOrEmpty(e.Text));
        }

        public override bool IsClickable()
        {
            try
            {
                foreach(var e in _elements) e.Click();
                return true;
            } catch
            {
                return false;
            }
        }

    }
}
