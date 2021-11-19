using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumDemoFramework;
using SeleniumDemoFramework.Elements;
using System;
using TestProject1.Features;

namespace SeleniumDemoTests.Features
{
    [TestFixture]
    [Ignore(reason: "")]
    public class HeaderTest : TestBase
    {
        [Test]
        public void TestHeader()
        {
            Header header = null;
            Assert.DoesNotThrow(() =>
            {
                header = new Header(Browser.Driver);
            });
            Assert.True(header.Enabled());
            Assert.True(header.IsDisplayed());
            Assert.True(header.HasText());
            Assert.True(header.IsClickable());
        }

    }
}
