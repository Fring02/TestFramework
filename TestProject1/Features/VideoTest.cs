using NUnit.Framework;
using OpenQA.Selenium;
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
    [Ignore(reason:"")]
    public class VideoTest : TestBase
    {
        [Test]
        public void TestHyperlink()
        {
            Video video = null;
            Assert.DoesNotThrow(() =>
            {
                video = new Video(Browser.Driver);
            });
            Assert.True(video.Enabled());
            Assert.True(video.IsDisplayed());
            Assert.True(video.HasText());
            Assert.True(video.IsClickable());
        }
    }
}
