Feature: SearchInWiki
	Search for Test Automation in wiki

@mytag
Scenario: Search
	Given Navigate to the Wikipedia site
	Then Choose the English language
	Then Search for Test Automation
	Then Validate Unit testing text
	Then Validate Existence of Test Automation Interface Model picture