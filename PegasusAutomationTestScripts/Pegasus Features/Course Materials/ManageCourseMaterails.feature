Feature: ManageCourseMaterails
	This feature file will consist of all the test cases of Course Materail page of Instructor

@ManageCourseMaterails
Scenario: Navigate to Manage Course Material page
Given I have clicked on "Course Materials" Page

Scenario: Select Add Assignments Tile
Given I navigate to Wizard and Click on Add Assignment tile
When I select a Folder to add content from CL
And I Click on Add to MyCourse Button
When I Select a Target Folder to add
And I Click on Addy to My Course Button in CC View
