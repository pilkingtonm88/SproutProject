using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace SproutProject.Page_Objects
{
	class sproutHomePage
	{
		private IWebDriver driver;

		[FindsBy(How = How.Id, Using = "home")]
		public IWebElement Home { get; set; }

	}
}
