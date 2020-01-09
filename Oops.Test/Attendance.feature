Feature: Attendance
	In order to keep track of student and staff attendance
	I want a system that does this for me

Scenario: Mark a student present
	Given I have a student with Id as "1251515"
	When When I mark the student as present for "09-01-2020"
	Then the attendance for the student for the day should be "true"
