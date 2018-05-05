using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using ClassLibrary1;


namespace SproutProject
{
    [Binding]
    public class SproutHomeSteps
    {
		ClassLibrary1.webDriver webDriver=null;

		public webDriver WebDriver
		{
			get
			{
				return webDriver;
			}
			set
			{
				webDriver = value;
			}
		}

		[Given(@"I have entered the Sprout URL domain")]
        public void GivenIHaveEnteredTheSproutURLDomain()
        {
			WebDriver.url("https://sproutpeds.com");
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
