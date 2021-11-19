﻿using SeleniumDemoFramework.Generators;
using NUnit.Framework;

namespace SeleniumDemoFramework
{
    [TestFixture]
    public class TestBase
    {
        [TestFixtureSetUp]
        public static void Initialize()
        {
            Browser.Initialize();
        }        

        [TestFixtureTearDown]
        public static void TestFixtureTearDown()
        {
            Browser.Close();
        }

        [TearDown]
        public static void TearDown()
        {

            // Implement clean logout for user, remove session storage etc...) 

            Browser.Goto("");

            //if(Pages.TopNavigation.IsLoggedIn())
             //   Pages.TopNavigation.LogOut();

            //if(UserGenerator.LastGeneratedUser != null)
             //   Browser.Goto("????");
        }
    }
}
