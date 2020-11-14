using AutoFixture;
using BasicProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProject.Factori
{
    public class RegistrationFormFactori
    {
        public static RegistrationFormModel FillForm()
        {
            var fixture = new Fixture();
            var date = fixture.Create<DateTime>();

            return new RegistrationFormModel
            {

                firstNameField = "Petkan",
                lastNameField = "petkanov",
                selectGenger = "Mr",
                phoneNumberField = "0888888888",
                currentAddress = "ul.Sunny Beach",

                //City = fixture.Create<string>(),
                //Day = date.Day.ToString(),
                //Month = date.Month.ToString(),
                //Year = date.Year.ToString(),
                //ValidEmailAddress = fixture.Create<string>() + "@gmail.com",
                

            };
        }


            
    }
}
