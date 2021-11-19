using NUnit.Framework;
using SeleniumDemoFramework;
using SeleniumDemoFramework.Elements;
using System;

namespace SeleniumDemoTests.Features
{
    [TestFixture]
    public class ElementsTest : TestBase
    {
        [Test]
        public void TestHeader()
        { 
            var header = new Header(Browser.Driver);
            Assert.True(header.Enabled());
            Assert.True(header.IsDisplayed());
            Assert.True(header.HasText());
            Assert.True(header.IsClickable());
            Assert.True(header.ContainsNavbar());
        }
    }
}
