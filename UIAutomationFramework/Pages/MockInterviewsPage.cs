using OpenQA.Selenium;

namespace UIAutomationFramework.Pages
{
	public class MockInterviewsPage : BasePage
	{
		public IWebElement loginFormTitle => driver.FindElement(By.CssSelector(".Login_loginText__heJKr h2"));
        public IWebElement loginFormUserNameLabel => driver.FindElement(By.XPath("(//form//label)[1]"));
        public IWebElement loginFormUserNameInput => driver.FindElement(By.XPath("(//form//input)[1]"));
        public IWebElement loginFormPasswordLabel => driver.FindElement(By.XPath("(//form//label)[2]"));
        public IWebElement loginFormPasswordInput => driver.FindElement(By.XPath("(//form//input)[2]"));
        public IWebElement loginFormLoginButton => driver.FindElement(By.CssSelector(".Login_buttonOuterDiv__vT8CL>button"));
        public IWebElement loginFormErrorMessage => driver.FindElement(By.CssSelector(".Login_errorMessage__Hhsw0>p"));

        public void FillOutLoginForm(string username = "techglobal@gmail.com", string password = "techglobal")
        {
            loginFormUserNameInput.SendKeys(username);
            loginFormPasswordInput.SendKeys(password);
        }
    }
}

