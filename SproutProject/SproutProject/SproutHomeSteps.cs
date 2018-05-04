using System;
using TechTalk.SpecFlow;

namespace SproutProject
{
    [Binding]
    public class SproutHomeSteps
    {
        [Given(@"I have entered the Sprout URL domain")]
        public void GivenIHaveEnteredTheSproutURLDomain()
        {
            
        }
        
        [Given(@"I have initiated the HTTP request")]
        public void GivenIHaveInitiatedTheHTTPRequest()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the page loads")]
        public void WhenThePageLoads()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Sprout Home page should load")]
        public void ThenTheSproutHomePageShouldLoad()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
