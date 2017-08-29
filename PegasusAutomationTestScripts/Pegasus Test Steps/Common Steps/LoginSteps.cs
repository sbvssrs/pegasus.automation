using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using PegasusAutomationFramework.CommonRepository;
using Pegasus.Pages.Pegasus_Modules.Common_Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PegasusAutomationTestScripts.Pegasus_Test_Steps
{
    [Binding]
    class LoginSteps : LoginPage
    {

        [Given(@"I have Opened the Browser")]
        public void LaunchTheApplication()
        {
           //new AutomationManager().StarttheBrowser();
            new BrowserFactory().SetUpDriver();
        }

        [When(@"I Enter the User Name and Password")]
       public void WhenIEnterTheUserNameAndPassword()
        {

            try
            {
                base.WaitForElement();
                base.EnterTheUsername();
                base.WaitForElement();
                base.EnterThePassword();
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                base.TakeScreenShot("LoginPage");
                e.GetBaseException();
            }
        }

        [When(@"I click on Sign in")]
        public void WhenIClickOnSignIn()
        {
            try
            {
                base.WaitForElement();
                base.ClickOnSignInButton();
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                base.TakeScreenShot("WhenIClickOnSignIn");
                e.GetBaseException();
                throw new Exception("Unable to click on SingIn Button");
            }
        }

        [Then(@"I shoul be navigated into ""(.*)"" Page\.")]
        public void ThenIShoulBeNavigatedIntoPage_(string expectedPageTitle)
        {
            Thread.Sleep(2000);
            string actualpagetile = base.getPagetile();
            Assert.AreEqual(expectedPageTitle, actualpagetile);
        }
    }
};