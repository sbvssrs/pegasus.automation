using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Pegasus.Pages.Pegasus_Modules.Instructor_Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace PegasusAutomationTestScripts.Pegasus_Test_Steps
{
    [Binding]
    public sealed class ProgramAdminSteps : ProgramAdminPage
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

    }
}
