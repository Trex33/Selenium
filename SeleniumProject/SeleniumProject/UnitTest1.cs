using System;
using NUnit.Framework;

namespace SeleniumProject
{
    [TestFixture]
    public class FirefoxTesting : Hooks
    {
        [Test]
        public void FirefoxWikiTest()
        {
            Driver.Navigate().GoToUrl("https://www.wikipedia.org");
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                                                                "asd");
        }
    }

    [TestFixture]
    public class ChromeTesting : Hooks
    {
        [Test]
        public void ChromeWikiTest()
        {
            Driver.Navigate().GoToUrl("https://www.wikipedia.org");
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                                                                "asd");
        }
    }
}
