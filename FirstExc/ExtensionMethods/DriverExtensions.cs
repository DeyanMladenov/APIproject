using BasicProject.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProject.ExtensionMethods
{
    public static class DriverExtensions
    {
        public static void ScrollUp(this IWebDriver driver, int pixels)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript($"window.scrollBy(0, {-pixels})");
        }

        public static void ScrollDown(this IWebDriver driver, int pixels)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript($"window.scrollBy(0, {pixels})");
        }

        public static IWebElement ScrollToElement(this IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }
        public static WebElement ToBeVisible(this WebElement element)
        {
            var wait = new WebDriverWait(element.WrappedDriver, TimeSpan.FromSeconds(20));
            IWebElement nativeWebElement =
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element.By));

            return element;
        }



    }


}

