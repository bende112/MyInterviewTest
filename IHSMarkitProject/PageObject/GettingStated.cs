using System;
using OpenQA.Selenium;

namespace IHSMarkitProject.PageObject
{
    public class GettingStated
    {
        IWebDriver driver;
        public GettingStated(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickGettingStarted()
        {
            IWebElement GettingStartedButton = driver.FindElement(By.LinkText("Getting Started"));
            GettingStartedButton.Click();
        }

        public void CheckBackToEditorButton()
        {
            IWebElement BackToEditorButton = driver.FindElement(By.CssSelector("a.btn.btn-default"));
            String expectedTitle = "Back to Editor";
            String actualTitle = driver.Title;
            if (expectedTitle.Equals(actualTitle))
            {
                Console.WriteLine("The correct title.");
            }
            else
            {
                Console.WriteLine("n incorrect title.");
            }
        }
    }
}
