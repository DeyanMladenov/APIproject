using BasicProject.Core;
using BasicProject.ExtensionMethods;
using BasicProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProject.Pages.RegistrationFormPage
{
    public partial class RegistrationFormPage : BasePage
    {
        public void NavigateToRegistrationFormAndRegisterSuccessfully(RegistrationFormModel model)
        {
            selectFormsMenu.Click();
            practiceFormSubMenu.Click();
            firstNameField.SetText(model.firstNameField);
            lastNameField.SetText(model.lastNameField);
            selectGenger.Click();
            phoneNumberField.SetText(model.phoneNumberField);
            Driver.WrappedDriver.ScrollDown(250);
            currentAddress.SetText(model.currentAddress);
            Driver.WrappedDriver.ScrollToElement(submitButton.WrappedElement).Click();
            
           
           
        }
    }
}
