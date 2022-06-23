using ChallengingDom.Hooks;
using OpenQA.Selenium;
using System;
using System.Threading.Tasks;
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


        private By green = By.CssSelector("body > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(5)");
        private By red = By.CssSelector("body > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(3)");
        private By blue = By.CssSelector("body > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
        private By footer = By.XPath("#page-footer > div");
        private By content = By.XPath("//*[@id='content']/div/div/div/div[1]");
        private By answer = By.CssSelector("#canvas");
        private By pageTitle = By.CssSelector("#content > div > h3");
        private By edit = By.CssSelector("#content > div > div > div > div.large-10.columns > table > tbody > tr:nth-child(1) > td:nth-child(7) > a:nth-child(1)");
        private By delete = By.CssSelector("body > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(2) > table:nth-child(1) > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(7) > a:nth-child(2)");
        private By delete9 = By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[10]/td[7]/a[2]");
        private By tableRow = By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody");
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
            return driver.Url == "http://the-internet.herokuapp.com/challenging_dom";
        }
       
        public void ClickEdit()
        {
            driver.FindElement(edit).Click();
        }
        public bool IsTheUserRedirectedToEditPage()
        {
            return driver.Url == "http://the-internet.herokuapp.com/challenging_dom#edit"; 
        }
        public bool IsTheUserOnTheLandingPage()
        {
            return driver.Url == "http://the-internet.herokuapp.com/challenging_dom";
        }

        public void ClickDelete()
        {
            driver.FindElement(delete).Click();
        }
       
        public bool IsTheUserRedirectedToDeletePage()
        {
            return driver.Url == "http://the-internet.herokuapp.com/challenging_dom#delete";
        }

        public bool IsThreeButtonVisibleOnThePage()
        {
            return driver.FindElement(content).Displayed;
            
        }

        public void ClickBlueButton()
        {
            driver.FindElement(blue).Click();
        }

        

    }
}