using Appium_Android.Maps;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium_Android.Pages
{
    public class BasicInteractionsPage
    {

        private static BasicInteractionsPage _instance;
        public static BasicInteractionsPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BasicInteractionsPage();
                return _instance;
            }
        }
        protected BasicInteractionsMap Map
        {
            get
            {
                return new BasicInteractionsMap();
            }
        }
        public string SearchText(string text)
        {
            Map.Query.SendKeys(text);
            Map.BtnSearch.Click();
            return Map.TextFound.Text;
        }
        public string GetAlertTittle()
        {
            string alertTittleText = String.Empty;
            Map.BtnOpenDialog.Click();
            alertTittleText = Map.AlertTittle.Text;

            Map.BtnDismiss.Click();
            return alertTittleText;
        }
    }
}
