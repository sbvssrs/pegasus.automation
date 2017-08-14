using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Pegasus.Pages.Pegasus_Modules.Course_Materails_Page;

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
         base.SelectAssetsToAdd();
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


    }
}
