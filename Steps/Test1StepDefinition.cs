using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SubhamKumarOjhaAssignment.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SubhamKumarOjhaAssignment.Steps
{
    [Binding]
    public sealed class Test1StepDefinition
    {

        private IWebDriver driver;
        HomePage homepage;
        public Test1StepDefinition(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(3000);
        }

        [Then(@"Search for the Testers Talk")]
        public void ThenSearchForTheTestersTalk()
        {
            //driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(" Testers Talk ");
            //driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
            //Thread.Sleep(5000);
            homepage = new HomePage(driver);
            homepage.SearchText("Testers Talk ");
            Thread.Sleep(5000);
        }

        [Then(@"I navigate to results")]
        public void ThenINavigateToResults()
        {
            homepage = new HomePage(driver);
            homepage.clickOnChannel();
        }

        [Then(@"I Verify the title")]
        public void ThenIVerifyTheTitle()
        {
            Assert.AreEqual("Testers Talk - ", homepage.getTitle());
        }


    }
}
