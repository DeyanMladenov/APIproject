using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;

namespace BasicProject.Core
{
    public class WebDriver
    {
        private IWebDriver _webDriver;
        private WebDriverWait _webDriverWait;


        public IWebDriver WrappedDriver => _webDriver;

        public void Start(Browsers browser)
        {
            switch (browser)
            {
                case Browsers.Chrome:
                    _webDriver = new ChromeDriver(Environment.CurrentDirectory);
                    break;
                case Browsers.Firefox:
                    _webDriver = new FirefoxDriver(Environment.CurrentDirectory);
                    break;
                case Browsers.Edge:
                    _webDriver = new EdgeDriver(Environment.CurrentDirectory);
                    break;
                case Browsers.Opera:
                    _webDriver = new OperaDriver(Environment.CurrentDirectory);
                    break;
                case Browsers.Safari:
                    _webDriver = new SafariDriver(Environment.CurrentDirectory);
                    break;
                case Browsers.InternetExplorer:
                    _webDriver = new InternetExplorerDriver(Environment.CurrentDirectory);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browser), browser, null);
            }

            _webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));
        }


        public void Quit()
        {
            _webDriver.Quit();
        }

        public void GoToUrl(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
        }
        public string Url()
        {
            return WrappedDriver.Url;
        }

        public WebElement FindElement(By locator)
        {
            var wait = new WebDriverWait(WrappedDriver, TimeSpan.FromSeconds(10));
            IWebElement nativeWebElement =
                _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            WebElement element = new WebElement(_webDriver, nativeWebElement, locator);

            return element;
        }

        public List<WebElement> FindElements(By locator)
        {
            ReadOnlyCollection<IWebElement> nativeWebElements =
                _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
            var elements = new List<WebElement>();
            foreach (var nativeWebElement in nativeWebElements)
            {
                WebElement element = new WebElement(_webDriver, nativeWebElement, locator);
                elements.Add(element);
            }

            return elements;
        }
        public WebElement FindExistingElement(By locator)
        {
            IWebElement nativeWebElement = _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            WebElement element = new WebElement(_webDriver, nativeWebElement, locator);

            return element;
        }
        public void Navigate(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
        }
        public WebElement FindClickableElement(By locator)
        {
            IWebElement nativeWebElement = _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            WebElement element = new WebElement(_webDriver, nativeWebElement, locator);

            return element;
        }
        public WebElement FindVisibleElement(By locator)
        {
            IWebElement nativeWebElement = _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            WebElement element = new WebElement(_webDriver, nativeWebElement, locator);

            return element;
        }
        public void WaitUntilElementIsLoaded(int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_webDriver;
            WebDriverWait wait = new WebDriverWait(_webDriver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
            

    }

}

