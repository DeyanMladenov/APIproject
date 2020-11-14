using BasicProject.ExtensionMethods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BasicProject.Pages.NetteraTvPage
{
    public partial class NetteraTvPage
    {
        public void NavigateToNetteraAndPlayMovie()
        {
            logInButton.Click();
            userNameField.SetText("rahelo1");
            passwordField.SetText("bastardo");
            submitButton.Click();
            videotekaHeaderButton.Click();
            serialiLeftMenuButton.Click();
            Driver.WrappedDriver.ScrollDown(300);
            Driver.WaitUntilElementIsLoaded();
            Builder.MoveToElement(nextPage.WrappedElement).Click().Perform();
            favouriteSerial.Click();
            Driver.WaitUntilElementIsLoaded();
            favouriteEpisode.Click();
           
        }
        public void NavigateToNetteraAndPlayMovieAndChekForFavouriteButton()
        {
            logInButton.Click();
            userNameField.SetText("rahelo1");
            passwordField.SetText("bastardo");
            submitButton.Click();
            videotekaHeaderButton.Click();
            serialiLeftMenuButton.Click();
            Driver.WrappedDriver.ScrollDown(300);
            Driver.WaitUntilElementIsLoaded();
            Builder.MoveToElement(nextPage.WrappedElement).Click().Perform();
            Builder.MoveToElement(favouriteSerial.WrappedElement).Perform();
            Builder.MoveToElement(favourite.WrappedElement).Perform();
        }


    }
}
