using BasicProject.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProject.Tests
{
    public class BaseTest
    {
        protected WebDriver Driver { get; set; }

        protected Actions Builder { get; set; }

        protected SelectElement Select { get; set; }

        protected IJavaScriptExecutor JS { get; set; }

        public void Initialize()
        {
            Driver = new WebDriver();
            Driver.Start(Browsers.Chrome);
            Builder = new Actions(Driver.WrappedDriver);
            JS = (IJavaScriptExecutor)Driver.WrappedDriver;
            Driver.WrappedDriver.Manage().Window.Maximize();
        }
    }
}
