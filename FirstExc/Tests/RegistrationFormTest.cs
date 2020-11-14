using BasicProject.Factori;
using BasicProject.Models;
using BasicProject.Pages.RegistrationFormPage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework.Interfaces;
using System.IO;
using OpenQA.Selenium;

namespace BasicProject.Tests
{
    public class RegistrationFormTest : BaseTest
    {
        private RegistrationFormPage _registrationPage;
        private RegistrationFormModel _registrationModel;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.GoToUrl("https://demoqa.com/");
            _registrationPage = new RegistrationFormPage(Driver);
            _registrationModel = RegistrationFormFactori.FillForm();
        }
        [Test]
        public void NewRegistredUser()
        {
            _registrationPage.NavigateToRegistrationFormAndRegisterSuccessfully(_registrationModel);
            _registrationPage.AssertForCorrectTitle();
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
