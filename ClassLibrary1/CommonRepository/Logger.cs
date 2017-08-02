using System.Globalization;
using System;
using System.IO;
using OpenQA.Selenium;
using System.Drawing.Imaging;
using log4net;
using System.Collections;


namespace PegasusAutomationFramework.CommonRepository
{
    public class Logger : AutomationManager
    {
        private readonly ILog _Log4netLogger;
        private static ICollection _configLogs = log4net.Config.XmlConfigurator.Configure();
        public Logger GetInstance(Type T)
        {
            var logger = new Logger(T);

            return logger;

        }

        private Logger(Type T)
        {
            _Log4netLogger = LogManager.GetLogger("PegasusAutomationFramework");

        }

        public void TakeSreenShot(String fileName)
        {
          //  ITakesScreenshot screenshothandler = driver as ITakesScreenshot;
            Screenshot screenshot = ((ITakesScreenshot)AutomationManager.driver).GetScreenshot();
            screenshot.SaveAsFile(fileName, System.Drawing.Imaging.ImageFormat.Jpeg); 
        }

    }
}
