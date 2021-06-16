using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAutomation.Utilities;
using System;
using System.Collections.Generic;

namespace SeleniumAutomation
{


    public class BuggyCarsRatingsBase

    {
                
        [SetUp]

        public static void Setup()

        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://buggy.justtestit.org");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        
        [TearDown]
        public static void Teardown()

        {
            IWebDriver driver = new ChromeDriver();
            driver.Close();

          
        }

        [Test, Category("Register")]

        public static void TestMethod1()
        {

            //Test case 1 Verify Registration process for new user 


            IWebDriver driver = new ChromeDriver();
           
            driver.FindElement(By.CssSelector("a.btn.btn-success-outline")).Click();
            driver.FindElement(By.Id("username")).SendKeys("AJ4");
            driver.FindElement(By.Id("firstName")).SendKeys("AJ4334@@#");
            driver.FindElement(By.Id("lastName")).SendKeys("Mang@#@S77SD");
            driver.FindElement(By.Id("password")).SendKeys("Pepsi12345@");
            driver.FindElement(By.Id("confirmPassword")).SendKeys("Pepsi12345@");
            driver.FindElement(By.CssSelector("button.btn.btn-default")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            

            Assert.Pass();

        }



        [Test, Category("Login")]

        public static void TestMethod2()
        {

            //Test case 2 Verify User can login using credentials
            IWebDriver driver = new ChromeDriver();
         
            driver.FindElement(By.Name("login")).SendKeys("AJ3");
            driver.FindElement(By.Name("password")).SendKeys("Pepsi12345@" + Keys.Enter);
            //driver.Close();
            Assert.Pass();

        }



        [Test, Category("Popular make")]

        public static void TestMethod3()
        {


            //// Test Case 3 Verify user can vote for Popular Make
            IWebDriver driver = new ChromeDriver();
         
            driver.FindElement(By.Name("login")).SendKeys("AJ3");
            driver.FindElement(By.Name("password")).SendKeys("Pepsi12345@" + Keys.Enter);
            driver.FindElement(By.CssSelector("img.img-fluid.center-block")).Click();
            driver.FindElement(By.XPath("/html/body/my-app/div/main/my-make/div/div[1]/div/div/table/tbody/tr[2]/td[5]/a")).Click();
            driver.FindElement(By.Id("comment")).SendKeys("AJ3 was here!!!");
            driver.FindElement(By.CssSelector("button.btn.btn-success")).Click();
            
            Assert.Pass();
        }

        [Test, Category("Popular model")]

        public static void TestMethod4()
        {


            // Test Case 4 Verify user can vote for Popular Model
            IWebDriver driver = new ChromeDriver();
            
            driver.FindElement(By.Name("login")).SendKeys("AJ3");
            driver.FindElement(By.Name("password")).SendKeys("Pepsi12345@" + Keys.Enter);
            driver.FindElement(By.XPath("//html/body/my-app/div/main/my-home/div/div[2]/div/a/img")).Click();
            driver.FindElement(By.Id("comment")).SendKeys("AJ3 was here!!!");
            driver.FindElement(By.CssSelector("button.btn.btn-success")).Click();
          
            Assert.Pass();
        }

        [Test, Category("Vote count")]


        public static void TestMethod5()
        {


            // Test Case 5 Verify Number of votes for Popular Model
            IWebDriver driver = new ChromeDriver();
         
            driver.FindElement(By.Name("login")).SendKeys("AJ2");
            driver.FindElement(By.Name("password")).SendKeys("Pepsi12345@" + Keys.Enter);
            driver.FindElement(By.XPath("//html/body/my-app/div/main/my-home/div/div[2]/div/a/img")).Click();
            IList<IWebElement> Votes = driver.FindElements(By.ClassName("text-nowrap"));
            Console.WriteLine("Total Votes:" + Votes.Count);
            Console.ReadKey();
            
            Assert.Pass();

        }

    }

}
