using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject
{
    [TestFixture]
    public class FirefoxTesting : Hooks
    {
        [SetUp]
        public void Initialize()
        {
           Driver.Navigate().GoToUrl("https://www.wikipedia.org");
           
        }

        [Test]
        public void FirefoxSelectElement()
        {
            var language = Driver.FindElement(By.Id("searchLanguage"));
            var selectElement = new SelectElement(language);
            selectElement.SelectByValue("en");
        }
    }

    [TestFixture]
    public class ChromeTesting : Hooks
    {
        [Test]
        public void ChromeWikiTest()
        {
            Driver.Navigate().GoToUrl("https://www.wikipedia.org");
      
        }
    }
}
