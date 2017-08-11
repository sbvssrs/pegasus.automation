using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Pegasus.Pages.Pegasus_Modules.PADM_Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PegasusAutomationTestScripts.Pegasus_Test_Steps.Program_Admin_Steps
{
[Binding]
   public sealed class SectionSteps : SectionPage
    {

    [Given(@"I navigated to Section Page")]
    public void GivenINavigatedToSectionPage()
    {
        base.SelectSectionPage();
    }
    [Then(@"I should be redirected to ""(.*)"" Page")]
    public void ThenIShouldBeRedirectedToPage(string exPectedTabName)
    {
        base.WaitForElement();
        base.SwitchToIFrame("_ctl0_PageContent_ifrmMiddle");
        String actualTabName = base.GetInnerText("#divMngTemplate");
        Assert.AreEqual(exPectedTabName, actualTabName);

    }

    [Given(@"I click on Add Section button")]
    public void GivenIClickOnAddSectionButton()
    {
        base.ClickOnAddSectionButton();
    }
    [When(@"I Enter all the details in  create Section pop up")]
    public void WhenIEnterAllTheDetailsInCreateSectionPopUp()
    {
        base.EnterDetailsToSectionCreationPage();
    }
    [Given(@"I click on Context menu of Section ""(.*)""")]
    public void GivenIClickOnContextMenuOfSection(string cmenuOpt)
    {
        base.SetSectionInactive(cmenuOpt);
    }

    [Given(@"I click on the Context menu ""(.*)""")]
    public void GivenIClickOnTheContextMenu(string cmenuOption)
    {
        base.EnterSectionAsInstructor(cmenuOption);
    }
    [Then(@"I should be landed into default tab ""(.*)""")]
    public void ThenIShouldBeLandedIntoDefaultTab(string expectedTitile)
    {
        base.WaitForElement();
        string actualPageTitle = base.getPagetile();
        Assert.AreEqual(expectedTitile, actualPageTitle);
    }

    }
}
