using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ClassLibrary1
{
	public class webDriver
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

		public void findElementByClass(String className)
		{
			driver.FindElement(By.ClassName(className));
		}

		public void findElementByID(String ID)
		{
			driver.FindElement(By.Id(ID));
		}

		public void findElementByTagTitle()
		{
			driver.FindElement(By.TagName("title"));
		}

		public void quit()
			{
				driver.Quit();
			}
	}

}
