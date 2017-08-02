using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PegasusAutomationFramework.CommonRepository;
using OpenQA.Selenium;

namespace Pegasus.Pages.Pegasus_Modules.Instructor_Modules
{
    public class ProgramAdminPage : BasePage
    {
        public void OpenProgram(String programName)
        {
            IWebElement getProgramName = base.GetWebElementPropertiesByPartialLinkText(programName);
            base.WaitForElement();
            base.ClickOnLinkByJavaScriptExecuter(getProgramName);
        }
        
        public void ClickOnAddTemplatesButton()
        {
            base.WaitForElement();
            IWebElement getAddFromTempalteButton = base.GetWebElementProperties(By.Id("_ctl0_PageContent_ifrmMiddle"));
            base.SwitchToIframeByID(getAddFromTempalteButton);
            base.ClickonLinkByID("spnTemplate");
            base.WaitForElement();
            //Switiching back to Main frame
            base.SwithToDefaultContent();
            base.WaitForElement();
            base.SwitchToIFrame(ProgramAdminResources.ProgramAdmin_AddTemplatePopup_iframe_Locator_ID);
            base.WaitForElement();
        }
        public void SelectTempalteFromCatatalog()
        {
            base.ClickOnLinkByXPATH(ProgramAdminResources.ProgramAdmin_AddTemplate_SelectTemplate_Locator_xPath);

        }
        public void AddTemplateFromCatalog()
        {
            base.ClickonLinkByID(ProgramAdminResources.ProgramAdmin_AddTemplate_AddAndCloseButton_Locator_ID);
            base.WaitForElement();
            base.SwithToDefaultContent();
        }
    }
}
