using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoFramework.Elements
{
    public class Div : BaseElement
    {
        public Div(IWebDriver driver) : base(driver)
        {
            _element = driver.FindElement(By.Id("onetrust-consent-sdk"));
        }
    }
}
