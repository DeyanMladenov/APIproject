
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BasicProject.Pages.DatePickerTestCasePage;

namespace BasicProject.Tests
{
    public class DatePickerTestCaseTest : BaseTest
    {
        private DatePickerTestCasePage _datePickerTestCase;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _datePickerTestCase = new DatePickerTestCasePage(Driver);
            Driver.GoToUrl("https://demoqa.com/");
        }

        [Test]
        [TestCase("January")]
        [TestCase("February")]
        [TestCase("March")]
        [TestCase("April")]
        [TestCase("May")]
        [TestCase("June")]
        [TestCase("July")]
        [TestCase("August")]
        [TestCase("September")]
        [TestCase("October")]
        [TestCase("November")]
        [TestCase("December")]
        public void ChekForCorrectSetMonthAndDate(string month)
        {
            _datePickerTestCase.NavigateToDatePickerAndSelectMonth();
            _datePickerTestCase.allMonths(month).Click();
            _datePickerTestCase.NavigateToDatePickerAndSelectRandomDate();

            Assert.AreEqual(_datePickerTestCase.calendarHeader, $"{month} 2020");
        }



        [TearDown]
        public void TearDown()
        {

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }

            Driver.Quit();
        }





    }
}
