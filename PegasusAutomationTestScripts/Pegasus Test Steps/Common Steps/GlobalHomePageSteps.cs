using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pegasus.Pages.Pegasus_Modules.Common_Modules;

namespace PegasusAutomationTestScripts.Pegasus_Test_Steps
{
    [Binding]
    public sealed class GlobalHomePageSteps : GlobalHomePage
    {
        [Given(@"I clicked on create a Course")]
        public void GivenIClickedOnCreateACourse()
        {
            base.CreateNewCourse();
          //  base.TakeScreenShot("catalog");
        }
        [Given(@"Enter ""(.*)"" as the Search Keyword")]
        public void GivenEnterAsTheSearchKeyword(string authName)
        {
            
            base.SwithToCreateCourseWindow();
            base.WaitForElement();
            base.SearchByAuthorName(authName);
        }

        [Given(@"Select a Course")]
        public void GivenSelectACourse()
        {
            base.WaitForElement();
            base.selectACourse();
        }

        [Given(@"Enter ""(.*)"" as Coursename")]
        public void GivenEnterAsCoursename(string courseTitle)
        {
            base.EnterTheCourseTitle(courseTitle);
        }

        [When(@"I click on Finish button")]
        public void WhenIClickOnFinishButton()
        {
            base.ClickOnFinishButton();
        }

        [Then(@"I should be redirected to ""(.*)""")]
        public void ThenIShouldBeRedirectedTo(string expectedTitle)
        {
            base.SwithToDefaultContent();
            string actualPagetitle = base.getPagetile();
            Assert.AreEqual(expectedTitle,actualPagetitle);
        }
        //COPY THE COURSE
        [Given(@"I click on the ""(.*)"" CMenu of General Course")]
        public void GivenIClickOnTheCMenuOfGeneralCourse(string cmenuOption)
        {
            base.WaitForElement();
            base.SelectContextMenuOptions(cmenuOption);
        }

        [Given(@"I set the end date as ""(.*)""")]
        public void GivenISetTheEndDateAs(string endDate)
        {
            base.FillDatailsIntoCopyAsInstructorCoursePage(endDate);
        }
        [When(@"I click on Update")]
        public void WhenIClickOnUpdate()
        {
            base.CopyAsInstructorCourse();
        }
        [Then(@"I should be able to see the successfull copy message\.")]
        public void ThenIShouldBeAbleToSeeTheSuccessfullCopyMessage_()
        {
             base.VerifyTheSuccessMessage();
        }
        [Given(@"I click on ""(.*)""  cmenu of General Course")]
        [Given(@"I click on ""(.*)"" cmenu of General Course")]
        public void GivenIClickOnEditCourseInfoCmenu(string cMenuOption)
        {
            base.WaitForElement();
            base.SelectEditCourseInfoCMenu(cMenuOption);
        }
        [Given(@"I edit the Course Name")]
        public void GivenIEditTheCourseName()
        {
            base.WaitForElement();
            base.EditTheCourseTitle();
        }
        [When(@"I Click on the Update button")]
        public void WhenIClickOnTheUpdateButton()
        {
            base.UpdateTheCourse();
        }
        [Then(@"I should be able see ""(.*)"" successfully message")]
        public void ThenIShouldBeAbleSeeSuccessfullyMessage(string exceptedMessage)
        {
            base.WaitForElement();
            base.SwithToDefaultContent();
            base.VerifySuccessfullMessage(exceptedMessage);
        }

     }
  }
 
    

