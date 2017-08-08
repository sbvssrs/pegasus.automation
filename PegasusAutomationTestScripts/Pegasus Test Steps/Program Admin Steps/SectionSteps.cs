using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Pegasus.Pages.Pegasus_Modules.PADM_Pages;

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

    }
}
