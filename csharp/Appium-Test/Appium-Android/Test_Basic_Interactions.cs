using System;
using Appium_Android.Pages;
using Appium_Android.Utils;
using NUnit.Framework;

namespace Appium_Android
{
    [TestFixture()]
    public class Test_Basic_Interactions
    {
        [SetUp()]
        public void BeforeAll()
        {
            Test_Driver.Start();
        }
        [TearDown()]
        public void AfterAll()
        {
            Test_Driver.Quit();
        }
        [Test()]
        public void TestShouldSendKeysToSearchBoxThenCheckTheValue()
        {
            var text = "Hello World!";
            var textFound = BasicInteractionsPage.Instance.SearchText(text);
            Assert.AreEqual(text, textFound);
            
        }
        [Test()]
        public void TestShouldClickAButtonThatOpensAnAlertAndThenDismissesIt()
        {
            Test_Driver.Driver.StartActivity("io.appium.android.apis", ".app.AlertDialogSamples");
            string expectedText = String.Concat("Lorem ipsum dolor sit aie consectetur adipiscing", Environment.NewLine,
                "Plloaso mako nuto siwuf cakso dodtos anr koop.");
            string alertText = BasicInteractionsPage.Instance.GetAlertTittle();
            Assert.AreEqual(expectedText, alertText);
        }
    }
}
