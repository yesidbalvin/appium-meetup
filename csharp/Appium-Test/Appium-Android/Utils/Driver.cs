using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using System;

namespace Appium_Android.Utils
{
    public static class Test_Driver
    {
        private static String rootDirectory = System.IO.Path.GetFullPath($"{System.AppDomain.CurrentDomain.BaseDirectory.ToString()}/../../..");
        public static AndroidDriver<AndroidElement> Driver;
        public static void Start(string browserName = "")
        {
            Driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"),
               GetDesiredCapabilities(browserName), TimeSpan.FromSeconds(180));
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }
        public static void Quit()
        {
            Driver.Quit();
        }
        private static DesiredCapabilities GetDesiredCapabilities(string browserName)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.BrowserName, browserName);
            capabilities.SetCapability(MobileCapabilityType.PlatformName, "Android");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "7.1");
            capabilities.SetCapability(MobileCapabilityType.AutomationName, "UIAutomator2");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "emulator-5554");
            capabilities.SetCapability("appActivity", ".app.SearchInvoke");
            capabilities.SetCapability(MobileCapabilityType.App, $"{rootDirectory}/apps/ApiDemos-debug.apk");
            return capabilities;
        }
    }
}
