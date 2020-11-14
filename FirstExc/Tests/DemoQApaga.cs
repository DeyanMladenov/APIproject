using BasicProject.Pages.DemoQApaga;
using BasicProject.Tests;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.IO;
using OpenQA.Selenium;

namespace BasicProject
{
    public class Testss : BaseTest
    {
        private DemoQApaga _demoQApage;



        [SetUp]
        public void Setup()
        {
            Initialize();
            _demoQApage = new DemoQApaga(Driver);
            Driver.GoToUrl(_demoQApage.URL);
        }

        [Test]
        public void ChekingForCorrectMultipleSetUpData()
        {
            _demoQApage.NavigateToMultipleFieldAndTypeSelectedOptions();
            _demoQApage.ConfirmGreenColorIsDisplayed();
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