using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ClassLibrary1
{
	public abstract class webDriver
	{
		IWebDriver driver;

		public void main(string[] args)
			{
			}

		public void url(string url)
			{
			driver = new ChromeDriver();
			driver.Url = url;
			}

		public void quit()
			{
				driver.Quit();
			}
	}

}
