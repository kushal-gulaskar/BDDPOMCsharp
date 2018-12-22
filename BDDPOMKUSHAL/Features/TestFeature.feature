Feature: TestFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: TestFeature
	Given I have opened 'chrome' browser and hit the admin URL 
    And I have Login with Valid Admin user credentials and login
	Then I should get logged into Pressero Admin

	When I am on Admin home page
	When I click on support link
	When I click on support Mail
