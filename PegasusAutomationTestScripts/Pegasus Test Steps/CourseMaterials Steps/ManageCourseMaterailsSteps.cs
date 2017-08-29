using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pegasus.Pages.Pegasus_Modules.Course_Materails_Page;
using System.Threading;

namespace PegasusAutomationTestScripts.Pegasus_Test_Steps.CourseMaterials_Steps
{
 [Binding]
   public sealed class ManageCourseMaterailsSteps : ManageCourseMaterialsPage

    {
     [Given(@"I have clicked on ""(.*)"" Page")]
     public void GivenIHaveClickedOnPage(string tabName)
     {
         base.SelectCourseMaterailPage(tabName);
     }

     [Given(@"I navigate to Wizard and Click on Add Assignment tile")]
     public void GivenINavigateToWizardAndClickOnAddAssignmentTile()
     {
         base.AddAssignmentsInWizard();
     }
     [When(@"I select a Folder to add content from CL")]
     public void WhenISelectAFolderToAddContentFromCL()
     {
         base.OpenAFolderinCLWizard();
         base.WaitForElement();
         base.SelectAssetsToAdd(2);
     }
     [When(@"I Click on Add to MyCourse Button")]
     public void WhenIClickOnAddToMyCourseButton()
     {
         base.AddToMyCourseButtonInCL();
     }
     [When(@"I Select a Target Folder to add")]
     public void WhenISelectATargetFolderToAdd()
     {
         base.SelectTargetFolderinCC();
     }
     [When(@"I Click on Addy to My Course Button in CC View")]
     public void WhenIClickOnAddyToMyCourseButtonInCCView()
     {
         base.AddToMyCourseButtonInCC();
     }

     [Then(@"I should be able to see ""(.*)"" message")]
     public void ThenIShouldBeAbleToSeeMessage(string expectedMessage)
     {
         base.WaitForElement();
         string actualmessage = base.GetInnerTextByXpath("(//span[@class='CCSuccessMsg'])[2]");
         Assert.AreEqual(actualmessage,actualmessage);
     }
     [When(@"I close the Wizard by Clicking on Return to Manage Course Materials button")]
     public void WhenICloseTheWizardByClickingOnReturnToManageCourseMaterialsButton()
     {
         base.CloseTheWizard();
     }
     [Given(@"I click on Create Materail button")]
     public void GivenIClickOnCreateMaterailButton()
     {
         base.ClickOnCreateMaterailButton();
     }
     [When(@"i Select few folders")]
     public void WhenISelectFewFolders()
     {
         base.SelecttheFolder(3);
     }
    }
}
