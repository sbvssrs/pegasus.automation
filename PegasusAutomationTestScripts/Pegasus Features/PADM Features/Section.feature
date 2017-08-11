Feature: Section

Scenario: Navigate to Section tab
Given I navigated to Section Page
Then I should be redirected to "Manage Sections" Page

Scenario: SectionPage:Create a New Section
And I click on Add Section button
When I Enter all the details in  create Section pop up
Then I should be able to see "Section added successfully." message.

Scenario: SectionPage: Set an Existing Section InActive
Given I click on Context menu of Section "Set to Inactive"
Then I should be able to see "Section inactivated successfully." message.

Scenario: SectionPage: Enter Section as Instructor
Given I click on the Context menu "Enter Section as Instructor"
Then I should be landed into default tab "Today's View" 
