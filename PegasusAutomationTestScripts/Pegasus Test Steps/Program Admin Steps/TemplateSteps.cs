using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Pegasus.Pages.Pegasus_Modules.PADM_Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace PegasusAutomationTestScripts.Pegasus_Test_Steps
{
    [Binding]
    public sealed class TemplateSteps : TemplatePage
    {
        [Given(@"I click on ""(.*)"" Program title")]
        public void GivenIClickOnProgramTitle(string programName)
        {
            base.WaitForElement();
            base.OpenProgram(programName);
            Thread.Sleep(2000);
        }
        [Then(@"I should be redirected to ""(.*)"" page")]
        public void ThenIShouldBeRedirectedToPage(string expectedPageTitle)
        {
            base.WaitForElement();
            String ActualPageTitle = base.getPagetile();
            Assert.AreEqual(expectedPageTitle, ActualPageTitle);
        }

        //ADD Template from Catalog

        [Given(@"I click on Add Templates button")]
        public void GivenIClickOnAddTemplatesButton()
        {
            base.ClickOnAddTemplatesButton();
        }

        [Given(@"I Select MySpanishLab Course to Add")]
        public void GivenISelectMySpanishLabCourseToAdd()
        {
            base.SelectTempalteFromCatatalog();
        }
        [When(@"I click on Add button")]
        public void WhenIClickOnAddButton()
        {
            base.AddTemplateFromCatalog();
        }

        [Given(@"I click on Context Menu  ""(.*)"" of an Existing Template")]
        public void GivenIClickOnContextMenuOfAnExistingTemplate(string cMenuName)
        {
            base.ClickOnEditTemplate(cMenuName);
        }
        [When(@"I Edit the Template Name ""(.*)""")]
        public void WhenIEditTheTemplateName(string templateName)
        {
            base.SelectEditTemplatePopUp(templateName);
        }

        [Then(@"I should be able to see ""(.*)"" message\.")]
        public void ThenIShouldBeAbleToSeeMessage_(string successMessage)
        {
            //successTextContainer is an Class of the Div which holds SuccessFull Message.
            String actual = base.GetInnerText("#spanMessageBoard");
            base.WaitForElement();
            Assert.AreEqual(successMessage, actual);
        }

        [Given(@"I click on Context Menu ""(.*)""")]
        public void GivenIClickOnContextMenu(string cMenuOption)
        {
            base.CopyTemplateCMenu(cMenuOption);
        }
        [Given(@"I change the Title as ""(.*)""")]
        public void GivenIChangeTheTitleAs(string courseTitle)
        {
            base.CopyTemplatePopup(courseTitle);
        }

        [Then(@"I Should be able to see ""(.*)"" message\.")]
        public void ThenIShouldSeeMessage(string successMessage)
        {
            String actual = base.GetInnerText("#spanMessageBoard");
            base.WaitForElement();
            Assert.AreEqual(successMessage, actual);
        }
        [Given(@"I Select ""(.*)"" cmenu option of a Template")]
        public void GivenISelectCmenuOptionOfATemplate(string cMenuOption)
        {
            base.DeleteTemplate(cMenuOption);
        }
        [When(@"I Click on OK button on the confirmation alert")]
        public void WhenIClickOnOKButtonOnTheConfirmationAlert()
        {
            base.WaitForElement();
            base.ConfirmDeletion();
        }

    }
}
