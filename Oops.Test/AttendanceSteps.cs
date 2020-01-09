using System;
using TechTalk.SpecFlow;

namespace Oops.Test
{
    [Binding]
    public class AttendanceSteps
    {
        [Given(@"I have a person with Id as ""(.*)""")]
        public void GivenIHaveAPersonWithIdAs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"When I mark the person as present for ""(.*)""")]
        public void WhenWhenIMarkThePersonAsPresentFor(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the attendance for the person for the day should be ""(.*)""")]
        public void ThenTheAttendanceForThePersonForTheDayShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
