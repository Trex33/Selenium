using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SeleniumProject
{
    [Binding]
    public class SearchInWikiSteps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"Navigate to the Wikipedia site")]
        public void GivenOpenYourWebbrowser()
        {
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
            driver.Manage().Window.Maximize();
        }
        
        [Then(@"Choose the English language")]
        public void ThenChooseTheEnglishLanguage()
        {
            var language = driver.FindElement(By.Id("searchLanguage"));
            var selectElement = new SelectElement(language);
            selectElement.SelectByValue("en");
            Thread.Sleep(3000);
        }
        
        [Then(@"Search for Test Automation")]
        public void ThenSearchForTestAutomation()
        {
            var searchInput = driver.FindElement(By.Id("searchInput"));

            searchInput.Click();
            searchInput.Clear();
            searchInput.SendKeys("Test Automation");
            Thread.Sleep(3000);
            searchInput.SendKeys(Keys.ArrowDown);
            searchInput.Click();
            Thread.Sleep(3000);
            searchInput.SendKeys(Keys.Enter);

        }
        
        [Then(@"Validate Unit testing text")]
        public void ThenValidateUnitTestingText()
        {
            Assert.IsTrue(driver.FindElement(By.Id("Unit_testing")).Text.Contains("Unit testing"),
                driver.FindElement(By.Id("Unit_testing")) + " doesn't contains 'Unit testing'");
        }
        
        [Then(@"Validate Existence of Test Automation Interface Model picture")]
        public void ThenValidateExistenceOfTestAutomationInterfaceModelPicture()
        {
            var picture = driver.FindElement(By.CssSelector("[href*='/wiki/File:Test_Automation_Interface.png']"));
            Assert.IsTrue(picture.Displayed, "Test_Automation_Interface.png is not exist");
           
        }
    }
}
