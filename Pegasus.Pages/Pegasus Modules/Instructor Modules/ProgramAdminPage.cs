﻿using System;
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
        public void ClickOnEditTemplate(String cMenuName)
        {
            base.SwitchToIFrame(ProgramAdminResources.ProgramAdmin_TemplateGrid_iframe_Locator);
            base.WaitForElement();
            IWebElement getCMenuICON = base.GetWebElementPropertiesByXPath(ProgramAdminResources.ProgramAdmin_EditTempateCMenuIcon_Locator_Xpath);
            base.ClickOnLinkByJavaScriptExecuter(getCMenuICON);
            base.WaitForElement();
            IWebElement getCMenuOptions = base.GetWebElementPropertiesByPartialLinkText(cMenuName);
            base.ClickOnLinkByJavaScriptExecuter(getCMenuOptions);
            base.WaitForElement();
            base.SwithToDefaultContent();
        }
        public void SelectEditTemplatePopUp(String templateName)
        {
            base.SwitchToIFrame(ProgramAdminResources.ProgramAdmin_AddTemplatePopup_iframe_Locator_ID);
            base.WaitForElement();
            base.clearTextByID(ProgramAdminResources.ProgramAdmin_EditTemplate_TextBox_Locator);
            base.InsertTextByID(ProgramAdminResources.ProgramAdmin_EditTemplate_TextBox_Locator, templateName);
            base.WaitForElement();
            base.ClickonLinkByID(ProgramAdminResources.ProgramAdmin_EditTemplate_SaveAndCloseButton_Locator);
        }
    }
}



