using OpenQA.Selenium;

namespace UIAutomationFramework.Utils
{
	public class ElementHandler
	{
		public static void ClickListElement(IList<IWebElement> elementList, string elementText)
		{
			foreach(IWebElement element in elementList)
			{
				if (element.Text.Equals(elementText))
				{
					element.Click();
					break;
				}
			}
		}

        public static void ClickListElement(IList<IWebElement> elementList, int index)
        {
			elementList[index].Click();
        }
    }
}

