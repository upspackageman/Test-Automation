using Automation.Extensions.Contracts;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace Automation.Extensions.Components
{
    public class WebDriverFactory
    {
        private readonly DriverParams _driverParams;
        public WebDriverFactory(string driverParamsJson) : this(LoadParams(driverParamsJson)) { }

        public WebDriverFactory(DriverParams driverParams)
        {
            _driverParams = driverParams;
            if (string.IsNullOrEmpty(driverParams.Binaries) || driverParams.Binaries ==".")
            {
                _driverParams.Binaries = Environment.CurrentDirectory;
            }
        }

        //Genereates web-driver based on input parameter
        //return webdriver instance

        public IWebDriver Get()
        {
            if (!string.Equals(_driverParams.Source, "REMOTE", StringComparison.OrdinalIgnoreCase))
            {
                return GetDriver();
            }
            return GetRemoteDriver();
        }

        //local Webdrivers
        private IWebDriver GetChrome() => new ChromeDriver(_driverParams.Binaries);

        private IWebDriver GetFirefox() => new FirefoxDriver(_driverParams.Binaries);

        private IWebDriver GetEdge() => new EdgeDriver(_driverParams.Binaries);

        private IWebDriver GetDriver()
        {
            switch (_driverParams.Driver.ToUpper())
            {
                case "EDGE": return GetEdge();
                case "FIREFOX": return GetFirefox();
                case "CHROME": return GetChrome();
                default:  return GetChrome();
            }
            
        }

        //remote webdrivers

        private IWebDriver GetRemoteChrome() => new RemoteWebDriver(new Uri(_driverParams.Binaries), new ChromeOptions());

        private IWebDriver GetRemoteFirefox() => new RemoteWebDriver(new Uri(_driverParams.Binaries), new FirefoxOptions());

        private IWebDriver GetRemoteEdge() => new RemoteWebDriver(new Uri(_driverParams.Binaries), new EdgeOptions());

        private IWebDriver GetRemoteDriver()
        {
            switch (_driverParams.Driver.ToUpper())
            {
                case "EDGE": return GetRemoteEdge();
                case "FIREFOX": return GetRemoteFirefox();
                case "CHROME": return GetRemoteChrome();
                default: return GetRemoteChrome();
            }

        }

        private static DriverParams LoadParams(string driverParamsJson)
        {
            if(string.IsNullOrEmpty(driverParamsJson))  {
                return new DriverParams { Source = "Local", Driver = "Chrome", Binaries = "." };
            }
            return JsonConvert.DeserializeObject<DriverParams>(driverParamsJson);
        }

    }
}
