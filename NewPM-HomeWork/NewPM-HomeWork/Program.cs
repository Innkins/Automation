using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NewPM_HomeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            var df = new DriverFactory();
            var driver = df.Initialize();
            df.ConfigureWait(driver);

            var actualSkypeName = IndexPage.OpenPage(driver)
                .Search(Config.SearchName)
                .ClickOnFirstResult()
                .FindSkypeName();

            if (actualSkypeName == Config.ExpectedSkypeName)
            {
                Console.WriteLine("Bingo!");
            }
            else
            {
                Console.WriteLine("Skype not found");
            }

            Console.ReadLine();
            df.Quit(driver);
        }
    }
}
