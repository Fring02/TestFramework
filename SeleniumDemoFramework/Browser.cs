using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumDemoFramework
{
    public static class Browser
    {
        public static IWebDriver Driver { get; set; }


        public static void Initialize(IWebDriver webDriver, string url)
        {
            Driver = webDriver;
            Goto(url);
        }

        public static string Title => Driver.Title;

        public static string CurrentURL => Driver.Url;

        public static ISearchContext SearchContextDriver => Driver;

        public static void Goto(string url)
        {
            Driver.Url = url;
        }

        public static void Close()
        {
            Driver.Close();
        }
        
    }
}