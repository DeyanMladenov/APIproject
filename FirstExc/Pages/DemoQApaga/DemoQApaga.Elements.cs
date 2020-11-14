using BasicProject.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicProject.Pages.DemoQApaga
{
    public partial class DemoQApaga : BasePage
    {
        public DemoQApaga(WebDriver driver) : base(driver)
        {

        }
        public string URL { get { return "https://demoqa.com/auto-complete"; } }
        public WebElement multipleColorField => Driver.FindElement(By.XPath("//input[@id='autoCompleteMultipleInput']"));
        public WebElement redColor => Driver.FindElement(By.XPath("//div[@id='react-select-2-option-0']"));
        public WebElement blueColor => Driver.FindElement(By.XPath("//div[@id='react-select-2-option-1']"));
        public WebElement greenColor => Driver.FindElement(By.XPath("//div[@id='react-select-2-option-2']"));
        public WebElement yellowCollor => Driver.FindElement(By.XPath("//div[@id='react-select-2-option-3']"));
        public WebElement purpleColor => Driver.FindElement(By.XPath("//div[@id='react-select-2-option-4']"));
        public WebElement whiteColor => Driver.FindElement(By.XPath("//div[@id='react-select-2-option-5']"));
        public WebElement violetColor => Driver.FindElement(By.XPath("//div[@id='react-select-2-option-6']"));
        public WebElement magentaColor => Driver.FindElement(By.XPath("//div[@id='react-select-2-option-7']"));
        public WebElement GreenColor => Driver.FindElement(By.XPath("//div[@class='auto-complete__option auto-complete__option--is-focused css-1n7v3ny-option'][contains(text(), 'Green')] "));

    }
}
