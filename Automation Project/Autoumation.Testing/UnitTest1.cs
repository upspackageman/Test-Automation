using Automation.Extensions.Components;
using Automation.Extensions.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
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

        //[TestMethod]
        //public void WebElement()
        //{
        //    var driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();

        //    driver.Navigate().GoToUrl("https://www.mariedrake.com/post/api-testing-with-cypress");
        //    Thread.Sleep(3000);
        //    driver.FindElement(By.XPath("/html/body/div/div/div[3]/div/header/div/div[2]/div[2]/div/div/wix-dropdown-menu/nav/ul/li[3]/a/div/div/p")).Click();
        //    Thread.Sleep(10000);
        //    driver.Dispose();

        //}


        //[TestMethod]
        //public void SelectElement()
        //{
        //    var driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();

        //    driver.Navigate().GoToUrl("https://gravitymvctestapplication.azurewebsites.net/Course");
        //    Thread.Sleep(3000);
        //    var elem = driver.FindElement(By.XPath("//*[@id='SelectedDepartment']"));
        //    var selectElement = new SelectElement(elem);
        //    selectElement.SelectByValue("1");

        //    Thread.Sleep(10000);
        //    driver.Dispose();

        //}

        //[TestMethod]
        //public void WebDriverFactoryTest()
        //{
        //    var driver = new WebDriverFactory(new DriverParams { Driver = "edge", Binaries = @"C:\Users\William Ward\source\repos\Test-Automation\Automation Project\web-driver" }).Get();
        //    driver.Manage().Window.Maximize();

        //    driver.Navigate().GoToUrl("https://gravitymvctestapplication.azurewebsites.net/Course");
        //    Thread.Sleep(3000);
        //    var elem = driver.FindElement(By.XPath("//*[@id='SelectedDepartment']"));
        //    var selectElement = new SelectElement(elem);
        //    selectElement.SelectByValue("1");

        //    Thread.Sleep(10000);
        //    driver.Dispose();
        //}

        //[TestMethod]
        //public void GoToUrlTest()
        //{
        //    var driver = new WebDriverFactory(new DriverParams { Driver = "edge", Binaries = @"C:\Users\William Ward\source\repos\Test-Automation\Automation Project\web-driver" }).Get();
         

        //    driver.GoToUrl("https://gravitymvctestapplication.azurewebsites.net/Course");
        //    Thread.Sleep(3000);
        //    var elem = driver.FindElement(By.XPath("//*[@id='SelectedDepartment']"));
        //    var selectElement = new SelectElement(elem);
        //    selectElement.SelectByValue("1");

        //    Thread.Sleep(3000);
        //    driver.Dispose();
        //}

        //[TestMethod]
        //public void GetElementTest()
        //{
        //    var driver = new WebDriverFactory(new DriverParams { Driver = "edge", Binaries = @"C:\Users\William Ward\source\repos\Test-Automation\Automation Project\web-driver" }).Get();


        //    driver.GoToUrl("https://gravitymvctestapplication.azurewebsites.net/Course");
        //    Thread.Sleep(3000);
        //    driver.GetElement(By.XPath("//*[@id='SelectedDepartment']")).Click();

        //    Thread.Sleep(3000);
        //    driver.Dispose();
        //}


        //[TestMethod]
        //public void ASSelectTest()
        //{
        //    var driver = new WebDriverFactory(new DriverParams { Driver = "edge", Binaries = @"C:\Users\William Ward\source\repos\Test-Automation\Automation Project\web-driver" }).Get();


        //    driver.GoToUrl("https://gravitymvctestapplication.azurewebsites.net/Course");
        //    Thread.Sleep(3000);
        //    driver.FindElement(By.XPath("//*[@id='SelectedDepartment']")).AsSelect().SelectByValue("4");
        //    Thread.Sleep(3000);
        //    driver.Dispose();
        //}

        //[TestMethod]
        //public void GetElementsTest()
        //{
        //    var driver = new WebDriverFactory(new DriverParams { Driver = "edge", Binaries = @"C:\Users\William Ward\source\repos\Test-Automation\Automation Project\web-driver" }).Get();


        //    driver.GoToUrl("https://gravitymvctestapplication.azurewebsites.net/Course");
        //    Thread.Sleep(3000);
        //    driver.GetElements(By.XPath("//ul/li"));

        //    Thread.Sleep(3000);
        //    driver.Dispose();
        //}

        //[TestMethod]
        //public void GetVisibleElementTest()
        //{
        //    var driver = new WebDriverFactory(new DriverParams { Driver = "edge", Binaries = @"C:\Users\William Ward\source\repos\Test-Automation\Automation Project\web-driver" }).Get();

        //    driver.GoToUrl("https://gravitymvctestapplication.azurewebsites.net/Course");
        //    Thread.Sleep(3000);
        //    driver.GetVisibleElement(By.XPath("/html/body/header/nav/div/div/ul/li[3]/a")).Click();
        //    Thread.Sleep(3000);
        //    driver.Dispose();
        //}

        //[TestMethod]
        //public void GetVisibleElementsTest()
        //{
        //    var driver = new WebDriverFactory(new DriverParams { Driver = "edge", Binaries = @"C:\Users\William Ward\source\repos\Test-Automation\Automation Project\web-driver" }).Get();


        //    driver.GoToUrl("https://gravitymvctestapplication.azurewebsites.net/Course");
        //    Thread.Sleep(3000);
        //    driver.GetElements(By.XPath("//ul/li"));
        //    Thread.Sleep(3000);
        //    driver.Dispose();
        //}

        //[TestMethod]
        //public void GetEnabledElementTest()
        //{
        //    var driver = new WebDriverFactory(new DriverParams { Driver = "edge", Binaries = @"C:\Users\William Ward\source\repos\Test-Automation\Automation Project\web-driver" }).Get();

        //    driver.GoToUrl("https://gravitymvctestapplication.azurewebsites.net/Course");
        //    Thread.Sleep(3000);
        //    driver.GetVisibleElement(By.XPath("/html/body/header/nav/div/div/ul/li[3]/a")).Click();
        //    driver.GetEnabledElement(By.XPath("/html/body/div/main/form/div/p/input[1]")).SendKeys("YO HO HO!!!!! ");
        //    Thread.Sleep(3000);
        //    driver.Dispose();
        //}

        //[TestMethod]
        //public void VerticalWindowScrollSample()
        //{
        //    var driver = new WebDriverFactory(new DriverParams { Driver = "edge", Binaries = @"C:\Users\William Ward\source\repos\Test-Automation\Automation Project\web-driver" }).Get();
        //    driver.GoToUrl("https://gravitymvctestapplication.azurewebsites.net/Course");
        //    driver.Manage().Window.Size = new Size(400, 400);
        //    driver.VerticalWindowScroll(0);
        //    Thread.Sleep(10000);
        //    driver.Dispose();
        //}

        [TestMethod]
        public void ActionsTest()
        {
            var driver = new WebDriverFactory(new DriverParams { Driver = "edge", Binaries = @"C:\Users\William Ward\source\repos\Test-Automation\Automation Project\web-driver" }).Get();


            driver.GoToUrl("https://gravitymvctestapplication.azurewebsites.net/Course");
            Thread.Sleep(3000);
            driver.GetVisibleElement(By.XPath("/html/body/header/nav/div/div/ul/li[3]/a")).Actions().Click().Build().Perform();
            Thread.Sleep(3000);
            driver.Dispose();
        }
    }


}
