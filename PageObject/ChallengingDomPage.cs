using ChallengingDom.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengingDom.PageObject
{
    public class ChallengingDomPage
    {

        public IWebDriver driver;

        public ChallengingDomPage()
        {
            driver = WebHooks.driver;
        }


        public By green = By.CssSelector("body > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(5)");
        public By red = By.CssSelector("body > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(3)");
        public By blue = By.CssSelector("body > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
        
        public By answer = By.CssSelector("#canvas");
        public By pageTitle = By.CssSelector("#content > div > h3");
        public By edit = By.CssSelector("#content > div > div > div > div.large-10.columns > table > tbody > tr:nth-child(1) > td:nth-child(7) > a:nth-child(1)");
        public By delete = By.CssSelector("body > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(2) > table:nth-child(1) > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(7) > a:nth-child(2)");
       
        //IWebElement pageTitle => driver.FindElement(By.CssSelector("#content > div > h3"));
        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

        }
        public bool IsUserOnTheLandingPage()
        {
            return driver.FindElement(answer).Displayed;
        }

        public bool PageTitleText()
        {
            return driver.FindElement(pageTitle).Displayed;
        }

        public void ClickEdit()
        {
            driver.FindElement(edit).Click();
        }
        public bool IsTheUserRedirectedToEditPage()
        {
            return driver.Url == "http://the-internet.herokuapp.com/challenging_dom#edit"; 
        }
        
        public void ClickDelete()
        {
            driver.FindElement(delete).Click();
        }
        public void ClickBlueButton()
        {
            driver.FindElement(blue).Click();
        }
        public void BlueButtonID()
        {
            
    
        }
        public bool IsTheUserRedirectedToDeletePage()
        {
            return driver.Url == "http://the-internet.herokuapp.com/challenging_dom#delete";
        }






    }
}