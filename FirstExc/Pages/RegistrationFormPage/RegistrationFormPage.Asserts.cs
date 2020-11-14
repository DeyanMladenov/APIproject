using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProject.Pages.RegistrationFormPage
{
    public partial class RegistrationFormPage
    {
        public void AssertForCorrectTitle()
        {
            Assert.AreEqual(successRegistrationFormTitle, "Thanks for submitting the form");
        }
    }
}
