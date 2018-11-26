using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NewPM_HomeWork
{
    public class IndexPage : BasePage
    {
        public IndexPage(IWebDriver driver) : base(driver)
        {
        }

        public SearchResultPage Search(string name)
        {
            var searchField = Driver.FindElement(By.Id("SearchQuery"));
            searchField.SendKeys(name);
            searchField.Submit();
            return new SearchResultPage(Driver);
        }

        public static IndexPage OpenPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(Config.NewPMEndPoint);
            return new IndexPage(driver);
        }
    }
}
