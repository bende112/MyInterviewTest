using System;
using IHSMarkitProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace IHSMarkitProject
{
    
    public class TestClass
    {
        private IWebDriver driver;
        WebDriverWait _wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://dotnetfiddle.net/");
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        [Test]
        public void EditorTestPage()
        {
            EditorHomePage editorHomePage = new EditorHomePage(driver);
            editorHomePage.EditorPage();
            editorHomePage.UserEnterNameOnEditor();
            editorHomePage.UserClicksRunButton();
            editorHomePage.UserCheckOutPut();
            editorHomePage.ClickShareButton();
            editorHomePage.UserClickSaveButton();
            editorHomePage.CheckLoginPageIsDisplayed();
            editorHomePage.CloseLoginButton();
            driver.Close();
        }

        [Test]
        public void OptionSectionPage()
        {
            OptionSection optionSection = new OptionSection(driver);
            optionSection.HideOptions();
            driver.Close();
        }

        [Test]
        public void GettingStartedButton()
        {
            GettingStated gettingStated = new GettingStated(driver);
            gettingStated.ClickGettingStarted();
            gettingStated.CheckBackToEditorButton();
            driver.Close();
        }
        [Test]
        public void UserSelectPage()
        {
            SelectPackages selectPackages = new SelectPackages(driver);
            selectPackages.SearchPackage();
            selectPackages.SelectPackage();
            driver.Close();
        }
        
    }
}