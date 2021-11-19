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
    public class FooterTest : TestBase
    {
        [Test]
        public void TestFooter()
        {
            Footer footer = null;
            Assert.DoesNotThrow(() =>
            {
                footer = new Footer(Browser.Driver);
            });
            Assert.True(footer.Enabled());
            Assert.True(footer.IsDisplayed());
            Assert.True(footer.HasText());
            Assert.True(footer.IsClickable());
        }

    }
}
