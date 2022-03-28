using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Autoumation.Testing
{
    [TestClass]
    public class UnitTest1
    { 
        //[TestMethod]
        //public void WebDriver()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    Thread.Sleep(1000);
        //    driver.Dispose();

        //    driver = new FirefoxDriver();
        //    Thread.Sleep(1000);
        //    driver.Dispose();

        //    driver = new EdgeDriver();
        //    Thread.Sleep(1000);
        //    driver.Dispose();
        //}

        [TestMethod]
        public void WebElement()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.mariedrake.com/post/api-testing-with-cypress");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div/div[3]/div/header/div/div[2]/div[2]/div/div/wix-dropdown-menu/nav/ul/li[3]/a/div/div/p")).Click();
            Thread.Sleep(10000);
            driver.Dispose();

        }


        [TestMethod]
        public void SelectElement()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://gravitymvctestapplication.azurewebsites.net/Course");
            Thread.Sleep(3000);
            var elem = driver.FindElement(By.XPath("//*[@id='SelectedDepartment']"));
            var selectElement = new SelectElement(elem);
            selectElement.SelectByValue("1");

            Thread.Sleep(10000);
            driver.Dispose();

        }
    }
}
