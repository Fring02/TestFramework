using NUnit.Framework;
using SeleniumDemoFramework;
using SeleniumDemoFramework.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Features
{
    [TestFixture]
    [Ignore(reason: "")]
    internal class HyperlinkTest : TestBase
    {
        [Test]
        public void TestHyperlink()
        {
            Hyperlink hyperlink = null;
            Assert.DoesNotThrow(() =>
            {
                hyperlink = new Hyperlink(Browser.Driver);
            });
            Assert.True(hyperlink.Enabled());
            Assert.True(hyperlink.IsDisplayed());
            Assert.True(hyperlink.HasText());
            Assert.True(hyperlink.IsClickable());
        }
    }
}
