Feature: Registration
	Registration to create a new account as a new user

@UnitTest
Scenario: Create a new account
Given I am not logged in
When I complete the sign-up form
Then I am logged in
And my username is displayed

