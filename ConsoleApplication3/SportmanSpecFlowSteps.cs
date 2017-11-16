using System;
using TechTalk.SpecFlow;

namespace ConsoleApplication3
{
    [Binding]
    public class SportmanSpecFlowSteps
    {
        [Given(@"a sportman with name ""(.*)""")]
        public void GivenASportmanWithName(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"has personal results")]
        public void GivenHasPersonalResults()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I compare the results to the personal best")]
        public void WhenICompareTheResultsToThePersonalBest()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the personal best is the highest")]
        public void ThenThePersonalBestIsTheHighest()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
