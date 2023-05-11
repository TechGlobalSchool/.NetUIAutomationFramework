using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutomationFramework.Scripts;

[TestFixture]
public class TGHeaderTest : BaseTest
{
    [Test]
    public void ValidateTGLogo()
    { 
        Assert.True(basePage.logo.Displayed);
    }

    [Test]
    public void ValidateTGHeader()
    {
        Assert.True(basePage.heading.Displayed);
        Assert.That(basePage.heading.Text.Equals("Welcome to TechGlobal School\nTraining"));
    }
}
