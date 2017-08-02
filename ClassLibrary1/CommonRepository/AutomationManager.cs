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
        public void StarttheBrowser()
        {

            driver = new ChromeDriver(@"D:\chromedriver");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://pegasus5.qa.pegasus.pearsoncmg.com");  
        }

        //public void StarttheBrowser()
        //{

        //    //switch (ConfigurationManager.AppSettings.Get("Browser"))
        //    //{
        //    //    case "chrome" :

        //    //        driver = new ChromeDriver(@"D:\Java Softwares");
        //    //        driver.Navigate().GoToUrl("https://pegasus5.qa.pegasus.pearsoncmg.com");

        //    //        break;
        //    //    case "FireFox" :

        //    //        //Nothing here.
        //    //        break;
        //    //}


        public IWebDriver getDriver()
        {
            return driver;
        }

    }
}


