Feature: DataDrivenWithParameter

A short summary of the feature

@tag1
Scenario: Data Driven With Parameter
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up
	And I enter my Username text "JOVIEABIKE"
	And I enter my email text "jovieabike@ymail.com"
	And I enter my password text "abike12345"
	When I click on Sign up button
	Then I should be able to register successfully
	 
