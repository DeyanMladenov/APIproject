using BasicProject.ExtensionMethods;
using BasicProject.Tests;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace BasicProject.Pages.DemoQApaga
{
    public partial class DemoQApaga : BasePage
    {
        public void NavigateToMultipleFieldAndTypeSelectedOptions()
        {
            
            multipleColorField.Click();
            multipleColorField.WrappedElement.SendKeys("Red");
            multipleColorField.WrappedElement.SendKeys(Keys.Enter);
            multipleColorField.WrappedElement.SendKeys("Re");
        }
    }

   

}
