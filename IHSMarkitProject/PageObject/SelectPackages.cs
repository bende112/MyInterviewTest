using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace IHSMarkitProject.PageObject
{
    public class SelectPackages
    {
        IWebDriver driver;

        public SelectPackages(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void SearchPackage()
        {
            IWebElement PackageName = driver.FindElement(By.CssSelector("input[type='search']"));
            PackageName.SendKeys("nUnit (3.12.0)");
        }
        public void SelectPackage()
        {
            Actions actions = new Actions(driver);
            IWebElement NugetPackage = driver.FindElement(By.Id("ui-id-11"));
            actions.MoveToElement(NugetPackage);

            IWebElement NugetPackageVerion = driver.FindElement(By.CssSelector(".ui-corner-all.ui-state-active"));
            actions.MoveToElement(NugetPackageVerion);
            Thread.Sleep(1000);
            actions.Click().Build().Perform();
            
        }
    }
}
