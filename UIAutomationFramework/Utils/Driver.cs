﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutomationFramework.Utils
{
	public class Driver
	{
		private static IWebDriver driver;

		private Driver()
		{
		}

		public static IWebDriver GetDriver()
		{
			if(driver == null)
			{
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }
			return driver;
		}

		public static void QuitDriver()
		{
			if(driver != null)
			{
				driver.Quit();
				driver = null;
			}
		}
	}
}

