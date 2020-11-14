using BasicProject.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProject.Pages.NetteraTvPage
{
    public partial class NetteraTvPage : BasePage
    {
        public NetteraTvPage(WebDriver driver) : base(driver)
        {
        }

        public WebElement logInButton => Driver.FindExistingElement(By.XPath("/html/body/header/div/nav/a[6]"));
        public WebElement userNameField => Driver.FindExistingElement(By.XPath("//input[@id='fc-username']"));
        public WebElement passwordField => Driver.FindExistingElement(By.XPath("//input[@id='fc-password']"));
        public WebElement submitButton => Driver.FindExistingElement(By.XPath("//button[@type='submit'][contains(text(), 'Вход')]"));
        public WebElement videotekaHeaderButton => Driver.FindExistingElement(By.XPath("//*[.='Видеотека']"));
        public WebElement serialiLeftMenuButton => Driver.FindExistingElement(By.XPath("//a[@href='https://neterra.tv/videos/categories/series']"));
        public WebElement nextPage => Driver.FindExistingElement(By.XPath("//button[@class='js-page-btn'][@data-page='2']"));
        public WebElement favouriteSerial => Driver.FindExistingElement(By.XPath("//p[contains(text(),'Съни бийч')]"));
        public WebElement favouriteEpisode => Driver.FindExistingElement(By.XPath("//span[@class='playlist-item__title'][contains(text(), 'Сезон 1 Епизод 1')]"));
        public WebElement screen => Driver.FindExistingElement(By.XPath("//section[@id='js-player']"));
        public WebElement qualityButton => Driver.FindExistingElement(By.XPath("//button[@data-level-selector-button]"));
        public WebElement lowerQulity => Driver.FindExistingElement(By.XPath("//a[.='Low(360p)']"));
        public WebElement maxQuality => Driver.FindExistingElement(By.XPath("//a[.='High(480p)']"));
        public WebElement soudButton => Driver.FindExistingElement(By.XPath("//div[@class='drawer-icon media-control-icon']"));
        public string movieTitle => Driver.FindExistingElement(By.XPath("//section[@class='playlist-head is-small']")).Text;
        public WebElement abonamenti => Driver.FindExistingElement(By.XPath("//*[.='Абонаменти']"));
        public WebElement favourite => Driver.FindExistingElement(By.XPath("//i[@class='mdi mdi-heart-outline']"));
        public string favouriteName => Driver.FindExistingElement(By.XPath("//i[@class='mdi mdi-heart-outline']")).Text;

    }
}
