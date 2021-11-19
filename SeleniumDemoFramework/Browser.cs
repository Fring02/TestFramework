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

        private static string baseUrl;

        public static void Initialize(IWebDriver webDriver, string url)
        {
            baseUrl = url;
            Driver = webDriver;
            Goto("");
        }

        public static string Title => Driver.Title;

        public static string CurrentURL => Driver.Url;

        public static ISearchContext SearchContextDriver => Driver;

        public static void Goto(string url)
        {
            Driver.Url = baseUrl + url;
        }

        public static void Close()
        {
            Driver.Close();
        }
        
    }
}