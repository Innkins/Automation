using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NewPM_HomeWork
{
    public class SearchResultPage : BasePage
    {
        public SearchResultPage(IWebDriver driver) : base(driver)
        {
        }

        public MyProfilePage ClickOnFirstResult()
        {
            var searchResult = Driver.FindElement(By.XPath("//*[@id=\"PeopleResultsView\"]/tr/td[1]/a"));
            searchResult.Click();
            return new MyProfilePage(Driver);
        }
    }
}
