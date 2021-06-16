using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;


namespace SeleniumAutomation
{
   
    class Program
        {
            static void Main(string[] args)
            {

                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://buggy.justtestit.org");
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Test case 1 Verify Registration process for new user

                driver.FindElement(By.CssSelector("a.btn.btn-success-outline")).Click();
                driver.FindElement(By.Id("username")).SendKeys("AJ3");
                driver.FindElement(By.Id("firstName")).SendKeys("AJ3334@@#");
            driver.FindElement(By.Id("lastName")).SendKeys("Mang@#@S77SD");
            driver.FindElement(By.Id("password")).SendKeys("Pepsi12345@");
            driver.FindElement(By.Id("confirmPassword")).SendKeys("Pepsi12345@");
            driver.FindElement(By.CssSelector("button.btn.btn-default")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            

            //Test case 2 Verify User can login using credentials

            driver.FindElement(By.Name("login")).SendKeys("AJ3");
            driver.FindElement(By.Name("password")).SendKeys("Pepsi12345@" + Keys.Enter);
            


            //// Test Case 3 Verify user can vote for Popular Make
            driver.FindElement(By.Name("login")).SendKeys("AJ2");
            driver.FindElement(By.Name("password")).SendKeys("Pepsi12345@" + Keys.Enter);
            driver.FindElement(By.CssSelector("img.img-fluid.center-block")).Click();
            driver.FindElement(By.XPath("/html/body/my-app/div/main/my-make/div/div[1]/div/div/table/tbody/tr[2]/td[5]/a")).Click();
            driver.FindElement(By.Id("comment")).SendKeys("AJ2 was here!!!");
            driver.FindElement(By.CssSelector("button.btn.btn-success")).Click();
            

            // Test Case 4 Verify user can vote for Popular Model

            driver.FindElement(By.Name("login")).SendKeys("AJ2");
            driver.FindElement(By.Name("password")).SendKeys("Pepsi12345@" + Keys.Enter);
            driver.FindElement(By.XPath("//html/body/my-app/div/main/my-home/div/div[2]/div/a/img")).Click();
            driver.FindElement(By.Id("comment")).SendKeys("AJ2 was here!!!");
            driver.FindElement(By.CssSelector("button.btn.btn-success")).Click();

            //// Test Case 5 Verify Number of votes for Popular Model
            driver.FindElement(By.Name("login")).SendKeys("AJ2");
            driver.FindElement(By.Name("password")).SendKeys("Pepsi12345@" + Keys.Enter);
            driver.FindElement(By.XPath("//html/body/my-app/div/main/my-home/div/div[2]/div/a/img")).Click();
            IList<IWebElement> Votes = driver.FindElements(By.ClassName("text-nowrap"));
            Console.WriteLine("Total Votes:" + Votes.Count);
            Console.ReadKey();




        }
    }
}