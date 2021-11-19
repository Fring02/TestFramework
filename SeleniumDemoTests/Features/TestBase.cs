using SeleniumDemoFramework.Generators;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumDemoFramework.Elements;
using SeleniumDemoFramework;

namespace SeleniumDemoTests.Features
{
    [TestFixture]
    public class TestBase
    {
        [SetUp]
        public static void Setup()
        {
            Browser.Initialize(new ChromeDriver(), "https://www.coursera.org/");
        }

        [TearDown]
        public static void Releasdsae()
        {
            Browser.Close();
        }

    }
}
