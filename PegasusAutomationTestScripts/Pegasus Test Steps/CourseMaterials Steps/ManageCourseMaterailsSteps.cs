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

    }
}
