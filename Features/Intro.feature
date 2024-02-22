Feature: Intro Page

@only
Scenario: Navigate to Login page
	Given I navigate to the site
	When I click the skip button on intro page
	And I click the Login button
	Then I should see the Login page