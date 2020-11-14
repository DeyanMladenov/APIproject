using BasicProject.Core;
using BasicProject.Pages.DataPickerPage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework.Interfaces;
using System.IO;
using OpenQA.Selenium;

namespace BasicProject.Tests
{
    public class DataPickerTest : BaseTest
    {
        private DataPickerPage _dataPickerPage;


        [SetUp]
        public void SetUp()
        {
            Initialize();
            _dataPickerPage = new DataPickerPage(Driver);
            Driver.GoToUrl("https://demoqa.com/");
            //Driver.GoToUrl(_dataPickerPage.URL);
        }
        [Test]
        public void JanuaryTest()
        {
            _dataPickerPage.NavigateToDatePickerAndSetJanuary();
            _dataPickerPage.ComfirmCorrectSetUpDataForJanuary();
        }


        [TearDown]
        public void TearDown()
        {

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver.WrappedDriver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }

            Driver.Quit();
        }

    }
}
