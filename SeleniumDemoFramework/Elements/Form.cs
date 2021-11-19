using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumDemoFramework.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoFramework.Elements
{
    public class Form : BaseElement
    {
        public Form(IWebDriver driver) : base(driver)
        {
            _element = driver.FindElement(By.Id("login"));
        }
        /// <summary>
        /// Checks whether the form has attribute "Action"
        /// </summary>
        /// <returns></returns>
        public bool HasAction()
        {
            try
            {
                return string.IsNullOrEmpty(_element.GetAttribute("action"));
            }
            catch
            {
                return false;   
            }
        }
        /// <summary>
        /// Checks whether the form method equals the given method string
        /// </summary>
        /// <param name="method">Method: GET, POST</param>
        /// <returns></returns>
        public bool HasMethod(string method = "get")
        {
            try
            {
                return _element.GetAttribute("method") == method;
            }
            catch
            {
                return false;
            }
        }


        public void Submit(UserData data)
        {
            var login = data.Username;
            var password = data.Password;
            var loginInput = _element.FindElement(By.Name("text"));
            var passwordInput = _element.FindElement(By.Name("password"));
            loginInput.SendKeys(login);
            passwordInput.SendKeys(password);
            _element.Submit();
        }

        public bool InputType(string inputType = "text")
        {
            var inputs = _element.FindElements(By.TagName("input"));
            return inputs.Any(i => i.GetAttribute("type") == inputType);
        }
    }
}