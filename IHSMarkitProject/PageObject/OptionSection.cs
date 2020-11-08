using System;
using OpenQA.Selenium;

namespace IHSMarkitProject.PageObject
{
    public class OptionSection
    {
        IWebDriver driver;
        public OptionSection(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void HideOptions()
        {
            IWebElement HideButton = driver.FindElement(By.CssSelector(".sidebar .glyphicon.glyphicon-chevron-left"));
            HideButton.Click();
        }

        public void CheckOptionPanalIsHidden()
        {

        }
    }
    
}
