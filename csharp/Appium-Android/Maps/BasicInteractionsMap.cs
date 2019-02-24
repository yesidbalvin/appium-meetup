using Appium_Android.Utils;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium_Android.Maps
{
    public class BasicInteractionsMap
    {
        public AndroidElement Query
        {
            get
            {
                return Test_Driver.Driver.FindElementById("txt_query_prefill");
            }
        }

        public AndroidElement BtnSearch
        {
            get
            {
                return Test_Driver.Driver.FindElementById("btn_start_search");
            }
        }

        public AndroidElement TextFound
        {
            get
            {
                return Test_Driver.Driver.FindElementById("android:id/search_src_text");
            }
        }
        public AndroidElement BtnOpenDialog
        {
            get
            {
                return Test_Driver.Driver.FindElementById("io.appium.android.apis:id/two_buttons");
            }
        } 
        public AndroidElement AlertTittle
        {
            get
            {
                return Test_Driver.Driver.FindElementById("android:id/alertTitle");
            }
        }
        public AndroidElement BtnDismiss
        {
            get
            {
                return Test_Driver.Driver.FindElementById("android:id/button1");
            }
        }
    }
}
