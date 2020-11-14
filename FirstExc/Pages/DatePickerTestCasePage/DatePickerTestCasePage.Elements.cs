using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BasicProject.Core;

namespace BasicProject.Pages.DatePickerTestCasePage
{
    public partial class DatePickerTestCasePage : BasePage
    {
        public DatePickerTestCasePage(WebDriver driver) : base(driver)
        {
        }

        public WebElement selectWidgetsMenu => Driver.FindElement(By.XPath("//div[4]//div[1]//div[1]"));
        public WebElement datePickerSubMenu => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[4]/div/ul/li[3]"));
        public WebElement selectDateField => Driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']"));
        public WebElement calendarDropdown => Driver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']"));
        public WebElement allMonths(string month) => Driver.FindElement(By.XPath($"//option[.='{month}']"));
        List<WebElement> allYears => Driver.FindElements(By.XPath("//select[@class='react-datepicker__year-select']//option")).ToList();
        List<WebElement> allDays => Driver.FindElements(By.XPath("//div[@class='react-datepicker__month']//div")).ToList();
        public string calendarHeader => Driver.FindElement(By.XPath("//div[contains(@class, 'current-month')]")).Text;

    }
}
