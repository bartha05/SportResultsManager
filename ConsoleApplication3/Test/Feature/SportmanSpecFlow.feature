Feature: SportmanSpecFlow

Scenario: Verify_the_personal_Best
	Given a sportman with name "Teofil"
	And has personal results
	Then the personal best is the highest