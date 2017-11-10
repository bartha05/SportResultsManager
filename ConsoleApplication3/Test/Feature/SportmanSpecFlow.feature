Feature: SportmanSpecFlow
	

Scenario: Verify the personal Best
Given a sportman with name "Teofil"
And has personal results
When I compare the results to the personal best
Then the personal best is the highest