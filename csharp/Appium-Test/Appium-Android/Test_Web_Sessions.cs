using System;
using Appium_Android.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Appium_Android
{
    [TestFixture()]
    public class Test_Web_Sessions
    {
        [SetUp()]
        public void BeforeAll()
        {
            Test_Driver.Start("Chrome");
        }
        [TearDown()]
        public void AfterAll()
        {
            Test_Driver.Quit();
        }
        [Test()]
        public void TestShouldCreateAndDestroyAndroidwebSessions()
        {
            Test_Driver.Driver.Url = "https://www.google.com";
            String title = Test_Driver.Driver.Title;

            Assert.AreEqual("Google", title);

            Test_Driver.Driver.Quit();

            Assert.Throws<WebDriverException>(
                () => { title = Test_Driver.Driver.Title; });
        }
    }
}
