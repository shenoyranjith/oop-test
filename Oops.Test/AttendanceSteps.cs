using System;
using TechTalk.SpecFlow;

namespace Oops.Test
{
    [Binding]
    public class AttendanceSteps
    {
        [Given(@"I have a student with Id as ""(.*)""")]
        public void GivenIHaveAStudentWithIdAs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"When I mark the student as present for ""(.*)""")]
        public void WhenWhenIMarkTheStudentAsPresentFor(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the attendance for the student for the day should be ""(.*)""")]
        public void ThenTheAttendanceForTheStudentForTheDayShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
