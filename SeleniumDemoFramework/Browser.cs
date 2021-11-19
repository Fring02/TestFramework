using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumDemoFramework
{
    public class Browser
    {
        public static IWebDriver WebDriver { get; set; }
        public string environmentURL { get; set; }

        private static string baseUrl = "https://businessco.azurewebsites.net/"; //use app config for determining environment
        //private static IWebDriver webDriver = new FirefoxDriver();

        public Browser(IWebDriver webDriver)
        {
            environmentURL = ConfigurationManager.AppSettings["Base_URL"];
            WebDriver = webDriver;
        }

        public static void Initialize()
        {
            Goto("");
        }

        public static string Title
        {
            get { return WebDriver.Title; }
        }

        public static string CurrentURL
        {
            get { return WebDriver.Url; }
        }

        public static ISearchContext Driver
        {
            get { return WebDriver; }
        }

        public static void Goto(string url)
        {
            WebDriver.Url = baseUrl + url;
        }

        public static void Close()
        {
            WebDriver.Close();
        }
        
    }
}