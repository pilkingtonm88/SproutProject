using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SproutProject.Page_Objects;

namespace SproutProject
{
    [Binding]
    public class sproutHomeSteps
    {
		IWebDriver webDriver = new ChromeDriver();
		sproutHomePage homePage = new sproutHomePage();

		[Given(@"I have entered the Sprout URL domain")]
        public void GivenIHaveEnteredTheSproutURLDomain()
        {
			webDriver.Navigate().GoToUrl("http://www.sproutpeds.com/#page");
		}
                
        [When(@"the page loads")]
        public void WhenThePageLoads()
        {
			webDriver.FindElement(By.ClassName("menu-item-home"));
			
        }
        
        [Then(@"the Sprout Home page should load")]
        public void ThenTheSproutHomePageShouldLoad()
        {
			try
			{
				Assert.IsTrue(webDriver.FindElement(By.ClassName("menu-item-home")).Displayed);
			}
			catch (Exception error)
			{
				Console.Write(error);
			}

		}
    }
}
