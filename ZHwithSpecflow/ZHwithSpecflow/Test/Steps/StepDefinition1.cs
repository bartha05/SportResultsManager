using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;
using ZH;


namespace ZHwithSpecflow.Test.Steps
{
    [Binding]
    public sealed class StepDefinition1
    {
        public Sportman Sportman;
        public Sportman SportmanWithClassCategory;
        public Extensions Extensions = new Extensions();

        [Given(@"the WorldRecord is zero")]
        public void GivenTheWorldRecordIsZero()
        {
            Sportman.WorldRecord = 0;
        }

        [Given(@"a sportman with name (.*)")]
        public void GivenASportmanWithName(string name)
        {
            SportmanWithClassCategory = new Sportman(name);

            Console.WriteLine("New sportman is created! Name: " + SportmanWithClassCategory.Name);
        }

        [Given(@"he has personal results")]
        public void GivenHeHasPersonalResults()
        {
            Sportman = Extensions.CreateTheHighestResults(Sportman);
        }

        [When(@"I compare the results to the personal best")]
        public void WhenICompareTheResultsToThePersonalBest()
        {
            Console.WriteLine("The world record: " + Sportman.WorldRecord);
        }

        [Then(@"the personal best is the highest")]
        public void ThenThePersonalBestIsTheHighest()
        {
            Console.WriteLine("results:" + Sportman.WorldRecord + " - " + SportmanWithClassCategory.BestPersonalResult);
            Assert.AreEqual(SportmanWithClassCategory.BestPersonalResult, Sportman.WorldRecord);

        }

        [Given(@"another sportman with name (.*)")]
        public void GivenAnotherSportmanWithName(string name)
        {
            this.Sportman = new Sportman(name);
            Console.WriteLine("New sportman is created! Name: " + Sportman.Name);
        }

        [Given(@"he has the highest personal results")]
        public void GivenHeHasHighestPersonalResults()
        {
            SportmanWithClassCategory = Extensions.CreateTheHighestResults(SportmanWithClassCategory);
        }

        [When(@"I compare the results of the sportmen")]
        public void WhenICompareTheResultsOfTheSportmen()
        {
            Console.WriteLine("World record: " + Sportman.WorldRecord);
            Console.WriteLine(Sportman.Name + ":" + Sportman.BestPersonalResult);
            Console.WriteLine(SportmanWithClassCategory.Name + ":" + SportmanWithClassCategory.BestPersonalResult);
        }

        [Then(@"the world recorder is (.*)")]
        public void ThenTheWorldRecorderIs(string name)
        {
            Assert.AreEqual(SportmanWithClassCategory.Name, name);
        }

        [Then(@"the category of (.*) is class")]
        public void ThenTheCategoryIsClass(string name)
        {
            Assert.AreEqual(SportmanWithClassCategory.PersonalCategory, "class");
        }

        [Then(@"the category of (.*) is professional")]
        public void ThenTheCategoryfIsProfessional(string name)
        {
            Assert.AreEqual(Sportman.PersonalCategory, "professional");
        }

        [Then(@"the category of (.*) is amateur")]
        public void ThenTheCategoryIsAmateur(string name)
        {
            Assert.AreEqual(Sportman.PersonalCategory, "amateur");
        }

        [Then(@"the category of (.*) is also class")]
        public void ThenTheCategoryOfIsAlsoClass(string p0)
        {
            Assert.AreEqual(Sportman.PersonalCategory, "class");
        }

        [Given(@"he has personal results, which are between the (.*)% of the highest and the (.*)% of the highest")]
        public void GivenHeHasPersonalResultsWhichAreBetweenTheOfTheHighestAndTheOfTheHighest(int p0, int p1)
        {
            Sportman = Extensions.CreateProfessionalResults(Sportman);
        }

        [Given(@"he has personal results, which are lesser than the (.*)% of the highest")]
        public void GivenHeHasPersonalResultsWhichAreLesserThanTheOfTheHighest(int p0)
        {
            Sportman = Extensions.CreateAmateurResults(Sportman);
        }

        [Given(@"he has personal results which are higher than the (.*)% of the highest")]
        public void GivenHeHasPersonalResultsWhichAreHigherThanTheOfTheHighest(int p0)
        {
            Extensions.CreateClassResults(Sportman);
        }

    }
}
