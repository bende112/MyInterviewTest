using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using static System.Net.Mime.MediaTypeNames;

namespace IHSMarkitProject.PageObject
{
    public class EditorHomePage
    {
        IWebDriver driver;
        public EditorHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void EditorPage()
        {
        }

        public void UserEnterNameOnEditor()
        {
            string name = "Bende";
            IWebElement UserName = driver.FindElement(By.XPath("//*[@id='CodeForm']/div[2]/div[3]/div[1]/input"));
            string value = UserName.GetAttribute("placeholder");
            UserName.SendKeys(name);
        }

        public void UserClicksRunButton()
        {
            IWebElement RunButton = driver.FindElement(By.Id("run-button"));
            RunButton.Click();
        }

        public void UserCheckOutPut()
        {
            Assert.IsTrue(driver.PageSource.Contains("Hello World"));
            //IWebElement OutPutText = driver.FindElement(By.Id("output"));
            //IWebElement OutPutText = driver.FindElement(By.Id("output"));
            //if (!string.IsNullOrEmpty(OutPutText.Text) && OutPutText.Text == "Hello World")
            //{
                

            //}

        }

        public void ClickShareButton()
        {
            IWebElement OutPutText = driver.FindElement(By.Id("Share"));
            OutPutText.Click();
            Thread.Sleep(1000);
        }

        public void CheckLink()
        {
            string shareLink = "https://dotnetfiddle.net/”";
            if (shareLink.Contains("https://dotnetfiddle.net/”"))
            {
                driver.FindElement(By.CssSelector("#share-dialog .share-link"));
            }

            //string share_Link = "#share-dialog .share-link";
            //IWebElement OutPutText = driver.FindElement(By.CssSelector(share_Link));

        }

        public void UserClickSaveButton()
        {
            IWebElement SaveButton = driver.FindElement(By.Id("save-button"));
            SaveButton.Click();
            Thread.Sleep(1000);
        }

        public void CheckLoginPageIsDisplayed()
        {
            IWebElement PageContent = driver.FindElement(By.CssSelector(".modal-content #login-modal-label"));
            String expectedTitle = "Log in";
            String actualTitle = driver.Title;
            if (expectedTitle.Equals(actualTitle))
            {
                Console.WriteLine("The correct title is displayed on the web page.");
            }
            else
            {
                Console.WriteLine("n incorrect title is displayed on the web page.");
            }
        }

        public void CloseLoginButton()
        {
            IWebElement CloseButton = driver.FindElement(By.Id("login-modal"));
            CloseButton.Click();
            Thread.Sleep(1000);
        }
    }
}
