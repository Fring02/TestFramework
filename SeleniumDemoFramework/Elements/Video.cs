using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoFramework.Elements
{
    public class Video : BaseElement
    {
        public Video(IWebDriver driver) : base(driver)
        {
            _element = driver.FindElement(By.TagName("video"));
        }


    }
}
