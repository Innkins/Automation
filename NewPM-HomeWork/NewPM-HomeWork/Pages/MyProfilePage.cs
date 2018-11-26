using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NewPM_HomeWork
{
    public class MyProfilePage : BasePage
    {
        public MyProfilePage(IWebDriver driver) : base(driver)
        {
        }

        public string FindSkypeName()
        {
            var imElement = Driver.FindElement(By.XPath("//*[@id=\"tabs\"]/li[3]/a"));
            imElement.Click();
            var skypeName = Driver.FindElement(By.XPath("//*[contains(@class,\"infoBlock_3_1\")]/table/tbody/tr[2]/td[2]/a"));
            var actualSkypeName = skypeName.Text;
            return actualSkypeName;
        }
    }
}
