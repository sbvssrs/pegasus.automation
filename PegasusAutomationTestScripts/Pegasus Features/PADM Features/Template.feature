﻿Feature: Template
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

#Open Program as Program Admin
Scenario: Open Program as Program Admin
Given I click on "WL - Product" Program title
Then  I should be redirected to "Program Administration" page

#Add New Template from Catalog
Scenario: Add New Template from Catalog
Given I click on Add Templates button
And   I Select MySpanishLab Course to Add
When  I click on Add button
Then  I should be redirected to "Program Administration" page

#Edit an Existing Template
Scenario: Edit an existing Template
Given I click on Context Menu  "Edit Template Information" of an Existing Template
When I Edit the Template Name "MySpanishLab Template Edited"
Then I should be able to see "Template updated successfully." message.

#Copy an Existing template
Scenario: Copy an Existing Template as Template
Given I click on Context Menu "Copy as Template" 
And I change the Title as "MySpanishLab-Automated-Copy of"
Then I Should be able to see "Please wait while your copy or copies are being prepared. This may take up to 24 hours. You may need to refresh your screen to see your copies. If you copied as a template, it will appear on the Template tab." message.

#Delete an Existing Template
Scenario: Delete an existing template
Given I Select "  Delete" cmenu option of a Template
When I Click on OK button on the confirmation alert
Then I should be able to see "Templates deleted successfully." message.

