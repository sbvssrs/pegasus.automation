using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System.Reflection;


namespace PegasusAutomationFramework.CommonRepository
{
    public class BrowserFactory : AutomationManager
    {
           

        public void SetUpDriver()
        {   

         
           string Environment = (ConfigurationManager.AppSettings["Environment"]).ToString();
           string Browser = (ConfigurationManager.AppSettings["Browser"]).ToString();

            switch(Browser)
            {
                case "Chrome":
                driver = new ChromeDriver(@"D:\chromedriver");
                driver.Manage().Window.Maximize();
                break;
                case "Firefox" :
                Console.WriteLine("Nothing to launch");
                break;
            }

            switch (Environment)
            {
                case "CGIE":
                    driver.Navigate().GoToUrl("https://pegasus5.qa.pegasus.pearsoncmg.com");
                    break;
                case "VCD":
                     driver.Navigate().GoToUrl("https://pegasqausvcd.ecollege-labs.com/");
                    break;
                case "Prod":
                    driver.Navigate().GoToUrl("http://mylabs.px.pearsoned.com/");
                    break;
                case "mmndppe":
                    driver.Navigate().GoToUrl("http://portalppe.pearsoncmg.com");
                    break;
            }
        
        }


    }
}
