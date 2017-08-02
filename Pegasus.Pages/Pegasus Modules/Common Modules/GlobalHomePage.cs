using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PegasusAutomationFramework.CommonRepository;


namespace Pegasus.Pages.Pegasus_Modules.Common_Modules

{

    public class GlobalHomePage : BasePage
    {
        public void CreateNewCourse()
        {
            base.WaitForElement();
            base.ClickonLinkByID(GlobalHomePageResourceresx.globalhomepage_createcoursebutton_locator_id);
            base.WaitForElement();

        }
        public void SwithToCreateCourseWindow()
        {
            base.SwitchToIFrame(GlobalHomePageResourceresx.globalhomepage_createCourseiFrame_locator_iframename);
            base.WaitForElement();
        }

        public void SearchByAuthorName(String authName)
        {
            base.clearTextByID(GlobalHomePageResourceresx.globalhomepage_createcourse_serachkeyword_locator_id);
            base.WaitForElement();
            base.InsertTextByID(GlobalHomePageResourceresx.globalhomepage_createcourse_serachkeyword_locator_id, authName);
            base.ClickonLinkByID(GlobalHomePageResourceresx.globalhomepage_createCourse_searchbykeyword_nextbuton_locator_id);
        }

        public void selectACourse()
        {
            base.ClickOnLinkByXPATH(GlobalHomePageResourceresx.globalhomepage_createCourse_SelectCourseinCatalog_locator_Xpath);
        }

        public void EnterTheCourseTitle(String courseTitle)
        {
            base.InsertTextByID(GlobalHomePageResourceresx.globalhomepage_createCourse_locator_coursetitle_locator, courseTitle);
        }

        public void ClickOnFinishButton()
        {
            base.ClickonLinkByID(GlobalHomePageResourceresx.globalhomepage_createCourse_locator_Finish_locator);
        }

        public void SelectContextMenuOptions(String cmenuOption)
        {
            base.WaitForElement();
            IWebElement getCmenuIcon = base.GetWebElementPropertiesByXPath(GlobalHomePageResourceresx.globalhomepage_ContextMenuIcon_Xpath);
            base.ClickOnLinkByJavaScriptExecuter(getCmenuIcon);
            base.WaitForElement();
            IWebElement getContextMenuOptions = base.GetWebElementPropertiesByPartialLinkText(cmenuOption);
            base.WaitForElement();
            base.ClickOnLinkByJavaScriptExecuter(getContextMenuOptions);
        }

        public void FillDatailsIntoCopyAsInstructorCoursePage(String endDate) {

            base.WaitForElement();
            base.SwitchToIFrame(GlobalHomePageResourceresx.globalhomepage_CopyAsInstructorCourse_iframe);
            base.WaitForElement();
            base.InsertTextByID(GlobalHomePageResourceresx.globalhomepage_CopyAsInstructorCourse_EndDateLocator, endDate);
        }

        public void CopyAsInstructorCourse()
        {
            base.ClickonLinkByID(GlobalHomePageResourceresx.globalhomepage_CopyAsInstructorCourse_CopyButton_locator);
        }

        public void VerifyTheSuccessMessage()
        {
            String acutalMessage = base.GetInnerText(GlobalHomePageResourceresx.globalhomepage_CopyAsInstructorCourse_SuccefullMessage_Class);
            Assert.AreEqual("Copied as instructor course.", acutalMessage);
        }

        public void SelectEditCourseInfoCMenu(string cMenuOption){
            base.WaitForElement();
            IWebElement getCmenuIcon = base.GetWebElementPropertiesByXPath(GlobalHomePageResourceresx.globalhomepage_ContextMenuIcon_Xpath);
            base.ClickOnLinkByJavaScriptExecuter(getCmenuIcon);
            base.WaitForElement();
            IWebElement getCmenuOptions = base.GetWebElementPropertiesByPartialLinkText(cMenuOption);
            base.ClickOnLinkByJavaScriptExecuter(getCmenuOptions);
        }

        public void EditTheCourseTitle()
        {

            base.SwitchToIFrame(GlobalHomePageResourceresx.globalhomepage_CopyAsInstructorCourse_iframe);
            base.WaitForElement();
            base.clearTextByID(GlobalHomePageResourceresx.globalhomepage_EditCourseInfo_CourseTitle_Locator_ID);
            base.InsertTextByID(GlobalHomePageResourceresx.globalhomepage_EditCourseInfo_CourseTitle_Locator_ID, "MySpanishLab Automation Edited Course");
        }

        public void UpdateTheCourse()
        {
            base.ClickonLinkByID(GlobalHomePageResourceresx.globalhomepage_CopyAsInstructorCourse_CopyButton_locator);
        }
        
        public void VerifySuccessfullMessage(string expectedMessage)
        {
            string actualMessage = base.GetInnerText(GlobalHomePageResourceresx.globalhomepage_CopyAsInstructorCourse_SuccefullMessage_Class);
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
