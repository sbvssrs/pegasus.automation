using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace PegasusAutomationFramework.CommonRepository
{
    public class BasePage : BrowserFactory
    {


        #region Clicking Button or Link Using IDs
        // CLICK on LINKS 
        public void ClickonLinkByID(String elementID)
        {
            Logger.Info("hi");
            IWebElement ClickonLink = driver.FindElement(By.Id(elementID));
            ClickonLink.Click();
     
        }
        #endregion
        public void ClickOnLinkbyCSS(String elementID)
        {
            IWebElement ClickonLinkCSS = driver.FindElement(By.CssSelector(elementID));
            ClickonLinkCSS.Click();
        }
        public void ClickonLinkByClass(String elementID)
        {
            //Click on a Link or Button by CSS Selector as locator. 
            IWebElement ClickLinkByClass = driver.FindElement(By.ClassName(elementID));
            ClickLinkByClass.Click();
        }
        public void ClickOnLinkbyPartialLinkText(String elementID)
        {
            driver.FindElement(By.PartialLinkText(elementID));
        }


        // INSERT (KEY IN) Text
        public void InsertTextByID(String elementID, String textToFill)
        {
            //Insert the text to an text feild by id as a locator.
            IWebElement InsertTextByIdentity = driver.FindElement(By.Id(elementID));
            InsertTextByIdentity.SendKeys(textToFill);
        }
        public void InsertTextbyCSSClass(String elementID, String textToFill)
        {
            //Inser the text to a text field by class name as locator.
            IWebElement InsertTextByID = driver.FindElement(By.Id(elementID));
            InsertTextByID.SendKeys(textToFill);
        }

        public void InsertTextbyCSSClasse(String elementID, String textToFill)
        {
            IWebElement InsertTextByID = driver.FindElement(By.Id(elementID));
            InsertTextByID.SendKeys(textToFill);
        }
        public void WaitForElement()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        public void SwitchToIFrame(String frmName)
        {
            driver.SwitchTo().Frame(frmName);
        }
        public void SwitchToIframeByID (IWebElement frameID)
        {
            driver.SwitchTo().Frame(frameID);
        }
            
        public void SwithToDefaultContent()
        {
            driver.SwitchTo().DefaultContent();
        }

        public void ClickOnLinkByXPATH(String xpathLocator)
        {
            IWebElement ClickByXpath = driver.FindElement(By.XPath(xpathLocator));
            ClickByXpath.Click();
        }
        public void clearTextByID(String idAttribute)
        {
            IWebElement clearTxtbyID = driver.FindElement(By.Id(idAttribute));

            clearTxtbyID.Clear();
        }
        public string getPagetile()
        {
            return driver.Title;
        }

        public void WaitUntilElementVisibleByID(String elementID)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(elementID)));
        }

        public void WaitUntilElementVisibleByPartialLinkText(String elementID)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(elementID)));
        }

        public void MovetheMouseonElement(IWebElement elementLocator) {
            
            Actions action = new Actions(driver);

            action.MoveToElement(elementLocator).Perform();

        }

        public void DragandDroptheElement(IWebElement dragLocator, IWebElement droptLocator)
        {
            Actions action = new Actions(driver);
            action.DragAndDrop(dragLocator, droptLocator).Perform();
        }

        public void InternalScrollUntilElementIsVisible(IWebElement element)
        { 
            IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
            js.ExecuteScript("argument[10].scrollintoview(true)",element);

        }

        public void FullPageScrollDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("Scroll(0,-400)");

        }

        public void FullPageScrollUp()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("Scroll(0,400)");

        }

        public void FullPageScrollRight()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("Scroll(400,0)");

        }
        public void FullPageScrollLeft()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("Scroll(-400,0)");

        }

        public void SwitchToWindow()
        {
           String parentWidnow = driver.CurrentWindowHandle;
           foreach (string window in driver.WindowHandles) {
               driver.SwitchTo().Window(window);
           }
        }

        public void SwithToAlert()
        {
            IAlert popup = driver.SwitchTo().Alert();
        }

        public void TakeScreenShot(String fileName)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(fileName, System.Drawing.Imaging.ImageFormat.Png);

        }

        public IWebElement GetWebElementProperties(By by)
        {
            this.WaitForElement();
           return driver.FindElement(by);
        }
        protected IWebElement GetWebElementPropertiesByXPath(String xPathValue)
        {
            return GetWebElementProperties(By.XPath(xPathValue));   
        }

        protected IWebElement GetWebElementPropertiesByPartialLinkText(String patialLinkTextAttributeValue)
        {
            return GetWebElementProperties(By.PartialLinkText(patialLinkTextAttributeValue));
        }
        public void ClickOnLinkByJavaScriptExecuter(IWebElement iwebelement)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", iwebelement);   
        }

        public string GetInnerText(string element)
        {
          IWebElement MessageText =  driver.FindElement(By.CssSelector(element));
          string text = MessageText.Text;
          return text;
        }

        public void clickOnLinkByCss(string elementID){

            driver.FindElement(By.CssSelector(elementID));
        }

        public void DragNDroptheElement(IWebElement froMelement, IWebElement ToElement)
        {
            Actions action =  new Actions(driver);
            action.DragAndDrop(froMelement, ToElement).Perform();

        }
    
    }
}