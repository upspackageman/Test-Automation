using Automation.Extensions.Contracts;
using Newtonsoft.Json;


namespace Automation.Extensions.Components
{
    public class WebDriverFactory
    {
        private readonly DriverParams _driverParams;
        public WebDriverFactory(string driverParamsJson) : this(LoadParams(driverParamsJson)) { }

        public WebDriverFactory(DriverParams driverParams)
        {
            _driverParams = driverParams;
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
