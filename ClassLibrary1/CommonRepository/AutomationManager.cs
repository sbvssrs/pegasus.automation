using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System.Drawing.Design;


namespace PegasusAutomationFramework.CommonRepository
{
    public class AutomationManager
    {
        public static IWebDriver driver;

        public IWebDriver getDriver()
        {
            return driver;
        }

    }
}


