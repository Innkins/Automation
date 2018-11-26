using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NewPM_HomeWork
{
    public class DriverFactory
    {
        public IWebDriver Initialize()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }

        public void ConfigureWait(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void Quit(IWebDriver driver)
        {
            driver.Quit();
        }

    }
}
