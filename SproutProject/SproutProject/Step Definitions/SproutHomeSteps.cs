using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using ClassLibrary1;


namespace SproutProject
{
    [Binding]
    public class sproutHomeSteps
    {
		webDriver webDriver= new webDriver();

		[Given(@"I have entered the Sprout URL domain")]
        public void GivenIHaveEnteredTheSproutURLDomain()
        {
			webDriver.url("http://www.sproutpeds.com/#page");
		}
                
        [When(@"the page loads")]
        public void WhenThePageLoads()
        {
			webDriver.findElementByTitle();
			
        }
        
        [Then(@"the Sprout Home page should load")]
        public void ThenTheSproutHomePageShouldLoad()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
