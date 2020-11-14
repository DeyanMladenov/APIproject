﻿using BasicProject.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicProject.Pages.DataPickerPage
{
    public partial class DataPickerPage : BasePage
    {
        public DataPickerPage(WebDriver driver) : base(driver)
        {
        }
        //public string URL { get { return "http://demoqa.com/date-picker"; } }
        public WebElement selectWidgetsMenu => Driver.FindElement(By.XPath("//div[4]//div[1]//div[1]"));
        public WebElement datePickerSubMenu => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[4]/div/ul/li[3]"));
        public WebElement selectDateField => Driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']"));
        List<WebElement> allMonths => Driver.FindElements(By.XPath("//select[@class='react-datepicker__month-select']//option")).ToList();
        List<WebElement> allYears => Driver.FindElements(By.XPath("//select[@class='react-datepicker__year-select']//option")).ToList();
        List<WebElement> allDays => Driver.FindElements(By.XPath("//div[@class='react-datepicker__month']//div")).ToList();
        public WebElement calendarHeader => Driver.FindElement(By.XPath("//div[contains(@class, 'current-month')]"));

    }
}
