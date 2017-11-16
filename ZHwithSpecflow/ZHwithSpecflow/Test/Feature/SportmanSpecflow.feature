Feature: SportmanSpecflow

Background:
	Given the WorldRecord is zero

@myScenario
Scenario Outline: Verify the personal best result
	Given a sportman with name <Name>
	And he has the highest personal results 
	When I compare the results to the personal best
	Then the personal best is the highest 
Examples: 
| Name |
| Teofil |

Scenario Outline: Verify the 'class' category
	Given a sportman with name <Name1>
	And he has the highest personal results
	And another sportman with name <Name2>
	And he has personal results
	When I compare the results of the sportmen
	Then the world recorder is <Name1>
	And the category of <Name1> is class
Examples: 
| Name1  | Name2   |
| Teofil | Salamon |

Scenario Outline: Verify the 'professional' category
	Given a sportman with name <Name1>
	And he has the highest personal results
	And another sportman with name <Name2>
	And he has personal results, which are between the 30% of the highest and the 75% of the highest
	When I compare the results of the sportmen
	Then the category of <Name2> is professional
Examples:
| Name1  | Name2   | 
| Teofil | Salamon | 

Scenario Outline: Verify the 'amateur' category
	Given a sportman with name <Name1>
	And he has the highest personal results
	And another sportman with name <Name2>
	And he has personal results, which are lesser than the 30% of the highest
	When I compare the results of the sportmen
	Then the world recorder is <Name1>
	And the category of <Name2> is amateur
Examples: 
| Name1  | Name2   |
| Teofil | Salamon |

Scenario Outline: Verify that there can be only one Wordlrecorder, but there can be more class sportman 
	Given a sportman with name <Name1>
	And he has the highest personal results
	And another sportman with name <Name2>
	And he has personal results which are higher than the 75% of the highest 
	When I compare the results of the sportmen
	Then the world recorder is <Name1>
	And the category of <Name1> is class
	And the category of <Name2> is also class
Examples: 
| Name1  | Name2   |
| Teofil | Salamon | 