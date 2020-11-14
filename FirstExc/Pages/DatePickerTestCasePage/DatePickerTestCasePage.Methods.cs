using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using BasicProject.ExtensionMethods;

namespace BasicProject.Pages.DatePickerTestCasePage
{
    public partial class DatePickerTestCasePage : BasePage
    {
        public void NavigateToDatePickerAndSelectMonth()
        {
            selectWidgetsMenu.Click();
            Driver.WrappedDriver.ScrollToElement(datePickerSubMenu.WrappedElement).Click();
            selectDateField.Click();
            Driver.WrappedDriver.ScrollDown(90);
            selectDateField.WrappedElement.SendKeys(Keys.Control + "a" + Keys.Backspace);
            calendarDropdown.Click();
        }
        public void NavigateToDatePickerAndSelectRandomDate()
        {
            var random = new Random();
            var randomDayOfTheMonth = random.Next(allDays.Count);
            allDays[randomDayOfTheMonth].Click();
            selectDateField.Click();
        }

           


    }
}
