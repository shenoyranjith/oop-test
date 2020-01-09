Feature: Attendance
	In order to keep track of student and staff attendance
	I want a system that does this for me

Scenario: Mark a person present
	Given I have a person with Id as "1251515"
	When When I mark the person as present for "09-01-2020"
	Then the attendance for the person for the day should be "true"
