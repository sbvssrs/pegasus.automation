Feature: GlobalHomePage
	As an Instructor
	I want to verify the complete flow of global homepage
#Purpose: Creating a New Course in HED
Scenario: Create a New Course in Home Page
	Given I clicked on create a Course
	And Enter "Arriba" as the Search Keyword
	And Select a Course
	And Enter "MySpanishLabCourse" as Coursename
	When I click on Finish button
	Then I should be redirected to "Global Home"
#Purpose: Copying an Existing Course in HED
Scenario: Copy an Existing Genera Course
	Given I click on the "Copy as Instructor Course" CMenu of General Course
	And I set the end date as "12/12/2022"
	When I click on Update
	Then I should be able to see the successfull copy message.
Scenario: Edit an Existing Course
	Given I click on "Edit Course Info" cmenu of General Course
	And  I edit the Course Name 
	When I Click on the Update button
	Then I should be able see "Course updated successfully." successfully message
	
			