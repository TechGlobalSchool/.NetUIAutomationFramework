using System;
using OpenQA.Selenium;
using UIAutomationFramework.EnvironmentConfiguration;
using UIAutomationFramework.Utils;

namespace UIAutomationFramework.Pages
{
	public class BasePage : EnvironmentSettings
	{
        // Header elements
        public IWebElement logo => driver.FindElement(By.Id("logo"));
        public IWebElement heading => driver.FindElement(By.CssSelector(".HomePage_pageTitle__UAMbk"));
        public IWebElement practicesDropDown => driver.FindElement(By.Id("dropdown-button"));
        public IList<IWebElement> practicesDropDownOptions => driver.FindElements(By.CssSelector("#dropdown-menu a"));

        // Footer elements
        public IWebElement address => driver.FindElement(By.XPath("(//footer[@class='Footer_footer__kXlYa']//p)[1]"));
        public IWebElement copyRight => driver.FindElement(By.XPath("(//footer[@class='Footer_footer__kXlYa']//p)[2]"));
        public IList<IWebElement> socialMediaElements => driver.FindElements(By.CssSelector(".Footer_socials__7h4n1>a"));


        public void selectPracticesDropDownOption(string optionText)
        {
            practicesDropDown.Click();
            ElementHandler.ClickListElement(practicesDropDownOptions, optionText);
        }

        public void selectPracticesDropDownOption(int index)
        {
            practicesDropDown.Click();
            ElementHandler.ClickListElement(practicesDropDownOptions, index);
        }
    }
}

