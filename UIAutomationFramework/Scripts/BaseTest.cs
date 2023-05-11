using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UIAutomationFramework.EnvironmentConfiguration;
using UIAutomationFramework.Pages;
using UIAutomationFramework.Utils;

namespace UIAutomationFramework
{
	public class BaseTest : EnvironmentSettings
	{
        public BasePage basePage;
        public MockInterviewsPage mockInterviewsPage;

        [SetUp]
        public void SetUp()
        {
            driver = Driver.GetDriver();

            driver.Navigate().GoToUrl("https://techglobal-training.com/");
            basePage = new BasePage();
        }

        [TearDown]
        public void TeardDown()
        {
            Driver.QuitDriver();
        }
    }
}

