using BasicProject.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProject.Pages.RegistrationFormPage
{
    public partial class RegistrationFormPage : BasePage
    {
        public RegistrationFormPage(WebDriver driver) : base(driver)
        {
        }
        public WebElement selectFormsMenu => Driver.FindElement(By.XPath("//div[@class='home-body']//div[2]//div[1]//div[1]"));
        public WebElement practiceFormSubMenu => Driver.FindElement(By.XPath("//span[contains(text(),'Practice Form')]"));
        public WebElement firstNameField => Driver.FindElement(By.XPath("//input[@id='firstName']"));
        public WebElement lastNameField => Driver.FindElement(By.XPath("//input[@id='lastName']"));
        public WebElement selectGenger => Driver.FindElement(By.XPath("//label[contains(text(),'Male')]"));
        public WebElement phoneNumberField => Driver.FindElement(By.XPath("//input[@id='userNumber']"));
        public WebElement currentAddress => Driver.FindElement(By.XPath("//html/body/div/div/div/div[2]/div[2]/div[1]/form/div[9]/div[2]/textarea"));
        public WebElement submitButton => Driver.FindElement(By.XPath("//button[@id='submit']"));
        public string successRegistrationFormTitle => Driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div")).Text;
    }
}
