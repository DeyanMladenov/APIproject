using BasicProject.Core;
using BasicProject.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProject.Pages.DataPickerPage
{
    public partial class DataPickerPage : BasePage
    {
        public void NavigateToDatePickerAndSetJanuary()
        {
            selectWidgetsMenu.Click();
            Driver.WrappedDriver.ScrollToElement(datePickerSubMenu.WrappedElement).Click();
            selectDateField.Click();
            allMonths[0].Click();
            allDays[10].Click();
            selectDateField.Click();
            Builder.MoveToElement(allDays[4].WrappedElement).Perform();
        }
    }
}
