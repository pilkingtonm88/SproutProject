Feature: sproutHome
	In order to insure the Sprout home page is bug free
	As a tester
	I want to test the Home page

@regression
Scenario: Home Page comes up with URL request to Sproutpeds.com
	Given I have entered the Sprout URL domain
	And I have initiated the HTTP request
	When the page loads
	Then the Sprout Home page should load
