using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UIAutomationFramework.EnvironmentConfiguration;
using UIAutomationFramework.Pages;

namespace UIAutomationFramework
{
	public class BaseTest : EnvironmentSettings
	{
        public BasePage basePage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


            driver.Navigate().GoToUrl("https://techglobal-training.com/");
            basePage = new BasePage();
        }

        [TearDown]
        public void TeardDown()
        {
            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}

