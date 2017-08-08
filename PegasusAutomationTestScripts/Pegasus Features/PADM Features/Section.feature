Feature: Section

Scenario: SectionPage:Create a New Section
Given I navigated to Section Page
And I click on Add Section button
When I Enter all the details in  create Section pop up
Then I should be able to see "Section added successfully." message.