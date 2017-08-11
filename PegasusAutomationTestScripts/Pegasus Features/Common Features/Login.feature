Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Login to Pegasus Application as an Instructor
	Given I have Opened the Browser
	When I Enter the User Name and Password
	And  I click on Sign in
	Then I shoul be navigated into "Global Home" Page.
