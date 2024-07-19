using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubhamKumarOjhaAssignment.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By searchTextbox = By.XPath("//*[@name='search_query']");
        public  HomePage SearchText(string text)
        {
            driver.FindElement(searchTextbox).SendKeys(text);
            driver.FindElement(searchTextbox).SendKeys(Keys.Enter);
            return new HomePage(driver);
        }

        By channelName = By.LinkText("Testers Talk");

        public HomePage clickOnChannel()
        {
            driver.FindElement(channelName).Click();
            return new HomePage(driver);
        }

        public string getTitle()
        {
            return driver.Title;
        }


    }
}
