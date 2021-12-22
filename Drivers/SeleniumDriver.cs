using OpenQA.Selenium;
namespace Lab_Cucumber.Drivers
{
    public class SeleniumDriver
    {
        private IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;

        public SeleniumDriver(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        public IWebDriver Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            _scenarioContext.Set(driver, "WebDriver");
                
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
