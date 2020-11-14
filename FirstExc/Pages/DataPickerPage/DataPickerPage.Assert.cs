using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProject.Pages.DataPickerPage
{
    public partial class DataPickerPage
    {
        public void ComfirmCorrectSetUpDataForJanuary()
        {
            Assert.AreEqual(calendarHeader.Text, "January 2020");
            Assert.AreEqual(allDays[10].Text, "6");
            Assert.AreNotEqual(allDays[10].Text, "10");
            Assert.AreEqual(allDays[10].WrappedElement.GetCssValue("background-color"), "rgba(33, 107, 165, 1)");
            Assert.AreEqual(allDays[10].WrappedElement.GetCssValue("color"), "rgba(255, 255, 255, 1)");
            Assert.AreEqual(allDays[4].WrappedElement.GetCssValue("background-color"), "rgba(240, 240, 240, 1)");
            Assert.AreEqual(allDays[4].WrappedElement.GetCssValue("color"), "rgba(0, 0, 0, 1)");
        }
    }
}
