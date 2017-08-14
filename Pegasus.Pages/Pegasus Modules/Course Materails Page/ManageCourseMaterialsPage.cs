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
      public void AddAssignmentsInWizard(String tileName)
      {
          base.WaitForElement();
          base.ClickOnLinkbyPartialLinkText(tileName);
      }
    }
}
