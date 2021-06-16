using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.Utilities
{
    class BrowserUtility
    {
        public IWebDriver Init(IWebDriver driver)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://buggy.justtestit.org");
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
