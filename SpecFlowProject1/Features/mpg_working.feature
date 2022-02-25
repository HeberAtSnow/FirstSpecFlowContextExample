Feature: mpg_working

A short summary of the feature

@tag1
Scenario: Zero Gallons yields 0 MPG answer
	Given Miles driven is 80 and gallons uses is 0
	When calculating mpg 
	Then computed mpg is 0

Scenario: 80 Miles Per 1 gallon
	Given Miles driven is 80 and gallons uses is 1
	When calculating mpg
	Then computed mpg is 80.0
	And flag is true


