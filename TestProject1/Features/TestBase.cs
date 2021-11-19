using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumDemoFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Features
{
    [TestFixture]
    public class TestBase
    {
        protected static string Url = @"C:\Users\ASUS\source\repos\TestAutomationFrameworkSelenium\SeleniumDemoFramework\bin\Debug"; 
        [SetUp]
        public static void Setup()
        {
            Browser.Initialize(new ChromeDriver(Url), "https://www.coursera.org/");
        }

        [TearDown]
        public static void Release()
        {
            Browser.Close();
        }
    }
}
