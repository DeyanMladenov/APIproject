using BasicProject.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;

namespace BasicProject.Pages
{
    public abstract class BasePage
    {
        public BasePage(WebDriver driver)
        {
            Driver = driver;
            Builder = new Actions(driver.WrappedDriver);
        }
        public WebDriver Driver { get; }

        protected Actions Builder { get; set; }

        public WebElement ScrollTo(WebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }
        

    }


}


