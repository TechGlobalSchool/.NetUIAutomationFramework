
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UIAutomationFramework.Pages;


namespace UIAutomationFramework.Scripts;

[TestFixture]
	public class TGFooterTest : BaseTest
	{
    [Test]
    public void ValidateTGFooter()
    {
        Assert.True(basePage.address.Displayed);
        Assert.That(basePage.address.Text.Equals("2860 S River Rd Suite 350, Des Plaines IL 60018"));

        Assert.True(basePage.copyRight.Displayed);
        Assert.That(basePage.copyRight.Text.Equals("© 2023 TechGlobal - All Rights Reserved"));

        foreach(IWebElement element in basePage.socialMediaElements)
        {
            Assert.True(element.Displayed);
            Assert.True(element.Enabled);
            Assert.IsNotEmpty(element.GetAttribute("href"));
        }
    }
}

