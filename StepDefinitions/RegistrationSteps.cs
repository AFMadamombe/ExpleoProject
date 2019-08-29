using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using System.Threading;

namespace ExpleoProjectExample
{
    [Binding]
    public class RegistrationSteps
    {

        //WebDriver initialisation
        IWebDriver driver = new ChromeDriver();

        [Given(@"I am not logged in")]
        public void GivenIAmNotLoggedIn()
        {
            //Navigate to website
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/");
            Console.WriteLine("Opened URL");

            //Navigate to registration page
            IWebElement elementA = driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
            elementA.Click();

        }
        
        [When(@"I complete the sign-up form")]
        public void WhenICompleteTheSign_UpForm()
        {
            
            //Populate username field
            IWebElement elementB = driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
            elementB.SendKeys("TestUsername4");

            //Populate Email field
            IWebElement elementC = driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
            elementC.SendKeys("TestUsername4@gmail.com");

            //Populate password field
            IWebElement elementD = driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));
            elementD.SendKeys("TestPassword123");

            //Press Sign in button
            IWebElement elementE = driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));
            Thread.Sleep(2000);
            elementE.Click();
            Thread.Sleep(4000);

            Console.WriteLine("Executed test");
        }
        
        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            if (driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[2]/li[3]/a")).Displayed == true)
                Console.WriteLine("Logged in"); 
            else
                Console.WriteLine("Not logged in");

        }
        
        [Then(@"my username is displayed")]
        public void ThenMyUsernameIsDisplayed()
        {
            if (driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div/div/div/h4")).Displayed == true)
                Console.WriteLine("Username is displayed"); 
            else
                Console.WriteLine("Username is not displayed");
        }
    }
}
