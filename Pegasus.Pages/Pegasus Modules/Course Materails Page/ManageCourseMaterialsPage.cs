using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PegasusAutomationFramework.CommonRepository;
using OpenQA.Selenium;

namespace Pegasus.Pages.Pegasus_Modules.Course_Materails_Page
{
   public class ManageCourseMaterialsPage : BasePage
    {
      public void SelectCourseMaterailPage(string tabName)
       {
          base.WaitForElement();
          base.ClickOnLinkByXPATH(ManageCourseMaterialsResource.MCM_CourseMaterailMainMenu_Icon_Locator);
          base.WaitForElement();
          IWebElement getMenuOption = base.GetWebElementPropertiesByPartialLinkText(tabName);
          base.ClickOnLinkByJavaScriptExecuter(getMenuOption);
          //IWebElement getTabName = base.GetWebElementPropertiesByPartialLinkText(tabName);
          //base.ClickOnLinkByJavaScriptExecuter(getTabName);
       }
      public void AddAssignmentsInWizard()
      {
          base.WaitForElement();
          base.ClickOnLinkByXPATH(ManageCourseMaterialsResource.MCM_CourseMaterialWizar_AddAssignmentTile_Locator_Xpath);
      }
      public void OpenAFolderinCLWizard()
      {
          base.WaitForElement();
          base.SwitchToIFrame(ManageCourseMaterialsResource.MCM_CourseMaterailWizard_iFrame_Locator);
          base.WaitForElement();
          base.ClickOnLinkbyCSS(ManageCourseMaterialsResource.MCM_CoureMaterialWizard_SelectFolder_Locator_Css);
          base.WaitForElement();
          base.ClickOnLinkbyCSS(ManageCourseMaterialsResource.MCM_CourseMaterialWizard_SelectSourceFolderToAddContent_Locator_Css);
      }
      public void SelectAssetsToAdd()
      {
          for (int i = 1; i <= 3; i++)
          {
              base.ClickOnLinkByXPATH(String.Format("(//input[contains(@id,'grdContentLibrary$_ctrl1')])[{0}]", i));
          }
      }
      public void AddToMyCourseButtonInCL()
      {
          base.WaitForElement();
          base.ClickOnLinkByXPATH(ManageCourseMaterialsResource.MCM_CourseMaterilWizard_AddToMyCourseButton_XPATH_Loctator);
      }
      public void SelectTargetFolderinCC()
      {
          base.WaitForElement();
          base.ClickOnLinkbyCSS(ManageCourseMaterialsResource.MCM_CoureMaterialWizard_SelectFolder_Locator_Css);
          base.WaitForElement();
          base.ClickOnLinkbyCSS(ManageCourseMaterialsResource.MCM_CourseMaterialWizard_SelectSourceFolderToAddContent_Locator_Css);
      }
      public void AddToMyCourseButtonInCC()
      {
          base.WaitForElement();
          base.ClickonLinkByID(ManageCourseMaterialsResource.MCM_CourseMaterilWizard_AddToMyCourseButtonCC_Id);
      }
   }
}
