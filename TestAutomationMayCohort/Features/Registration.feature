Feature: Registration

In order for me to take full advantage of website 
I'll need to first be a registered customer

@tag1
Scenario: Valid Registration
	Given I navigate to the website
	And I click on Sign up
	And I enter my Username
	And I enter my email
	And I enter my password
	When I click on Sign up button
	Then I should be able to register successfully
	 