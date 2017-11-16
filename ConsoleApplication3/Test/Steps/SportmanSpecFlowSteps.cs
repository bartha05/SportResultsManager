using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using ZH;

namespace ConsoleApplication3.Test.Steps
{
    [Binding]
    public class SportmanSpecFlowSteps
    {
        private Sportman sportman1;
        //private ScenarioContext dd;
        public int highestscore;
        [Given(@"a sportman with name ""(.*)""")]
        public void GivenASportmanWithName(string sportman)
        {
            sportman1 = new Sportman(sportman);
        }
        
        [Given(@"has personal results")]
        public void GivenHasPersonalResults()
        {
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                var score = rand.Next(1, 10);
                 sportman1.NewResult(score);
                if (highestscore < score) highestscore = score;
            }
        }
        
       
        [Then(@"the personal best is the highest")]
        public void ThenThePersonalBestIsTheHighest()
        {
            Assert.AreEqual(highestscore, sportman1.BestPersonalResult);
        }
    }
}
