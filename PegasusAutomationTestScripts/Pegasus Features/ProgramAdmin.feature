﻿Feature: ProgramAdmin
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

#Open Program as Program Admin
Scenario: Open Program as Program Admin
Given I click on "WL - Product" Program title
Then I should be redirected to "Program Administration" page
#Add New Template from Catalog
Scenario: Add New Template from Catalog
Given I click on Add Templates button
And I Select MySpanishLab Course to Add
When I click on Add button
Then I should be redirected to "Program Administration" page