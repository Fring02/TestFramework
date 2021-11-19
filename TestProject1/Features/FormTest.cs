using NUnit.Framework;
using SeleniumDemoFramework;
using SeleniumDemoFramework.Elements;
using SeleniumDemoFramework.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Features
{
    public class FormTest : TestBase
    {
        [Test]
        [TestCase("admin", "admin123")]
        public void TestForm(string username, string password)
        {
            Browser.Goto(@"https://moodle.astanait.edu.kz/login/index.php");
            var data = new UserData
            {
                Username = username,
                Password = password
            };
            Form form = null;
            Assert.DoesNotThrow(() =>
            {
                form = new Form(Browser.Driver);
            });
            Assert.True(form.Enabled());
            Assert.True(form.IsDisplayed());
            Assert.True(form.HasText());
            Assert.True(form.IsClickable());
            Assert.True(form.HasAction());
            Assert.True(form.HasMethod("post"));
            Assert.DoesNotThrow(() =>
            {
                form.Submit(data);
            });
        }
    }
}
