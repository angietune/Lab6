Feature: Login
As a user
I want to open the application
So I can add a product

@mytag
Scenario: LoginNWApp
	Given I open "localhost:8080" url
	When I fill the following form
	| field | value |
	| name | user |
	| password | user |
	And click the login button
	Then I should be at the home page