using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PegasusAutomationFramework.CommonRepository;

namespace Pegasus.Pages.Pegasus_Modules.PADM_Pages
{
   public class SectionPage : BasePage
    {
      public void SelectSectionPage()
       {
           base.ClickonLinkByID(SectionPageResources.Sectoin_NavigateToSection_Locator_ID);
       }
      public void ClickOnAddSectionButton()
      {
          base.WaitForElement();
          base.SwitchToIFrame(SectionPageResources.Section_ManageSectionGrid_Iframe_Locator);
          base.ClickonLinkByID(SectionPageResources.Section_AddSectionButton_Locator_ID);
          base.SwithToDefaultContent();
      }
      public void EnterDetailsToSectionCreationPage()
      {
          base.WaitForElement();
          base.SwitchToIFrame(ProgramAdminResources.ProgramAdmin_AddTemplatePopup_iframe_Locator_ID);
          base.WaitForElement();
          base.InsertTextByID(SectionPageResources.Section_AddSection_CreationSectionPopup_SectionTitleTextBox_Locator_ID, "MySpanishLab New Automated Section");
          base.WaitForElement();
          base.SelectDropDownByIndex(SectionPageResources.Section_AddSection_CreateSectionPopup_SelectTemplate_Dropdown_Locator);
          base.WaitForElement();
          base.InsertTextByID(SectionPageResources.Section_AddSection_CreateSectionPopup_NoOfSections_Locator, "1");
          base.InsertTextByID("txtStartDate", base.GetTodayDate());
          base.InsertTextByID("txtEndDate", "08/08/2020");
          base.InsertTextByID("txtCourseDescription", "This is the New Section Created by Automated Script");
          base.ClickonLinkByID("btnAddClose");
          base.SwithToDefaultContent();
      }
    }
}
