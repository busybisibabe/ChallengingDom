using ChallengingDom.PageObject;
using FluentAssertions;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ChallengingDom.Steps
{
    [Binding]
    public class ChallengingDomSteps
    {
        ChallengingDomPage challengingDomPage = new ChallengingDomPage();

        [Given(@"that I navigate to ""(.*)""")]
        public void GivenThatINavigateTo(string url)
        {
            challengingDomPage.NavigateToWebsite(url);
        }

        [When(@"the user is on the landing page")]
        public void WhenTheUserIsOnTheLandingPage()
        {
            challengingDomPage.IsUserOnTheLandingPage().Should().BeTrue();
        }

        [Then(@"I verify that Challenging DOM is displayed as the Web Page Title")]
        public void ThenIVerifyThatChallengingDOMIsDisplayedAsTheWebPageTitle()
        {
            challengingDomPage.PageTitleText().Should().BeTrue();
        }

        [When(@"I click on edit")]
        public void WhenIClickOnEdit()
        {
            challengingDomPage.ClickEdit();
        }

        [Then(@"I should redirected to edit page")]
        public void ThenIShouldRedirectedToEditPage()
        {
            challengingDomPage.IsTheUserRedirectedToEditPage().Should().BeFalse();
        }

        [Then(@"it should  be not clickable")]
        public void ThenItShouldBeNotClickable()
        {
            challengingDomPage.IsUserOnTheLandingPage().Should().BeTrue();
        }

        [When(@"I count the numbers of rows")]
        public void WhenICountTheNumbersOfRows()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see ten rows on the table")]
        public void ThenIShouldSeeTenRowsOnTheTable()
        {
            ScenarioContext.Current.Pending();
        }

        //[Then(@"I should be not be redirected")]
        //public void ThenIShouldBeNotBeRedirected()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [When(@"I navigate to the blue button and click")]
        public void WhenINavigateToTheBlueButtonAndClick()
        {
            challengingDomPage.ClickBlueButton();
        }

        //[Then(@"the Blue ButtonID should change after clicking")]
        //public void ThenTheBlueButtonIDShouldChangeAfterClicking()
        //{
        //    Assert.assertTrue(challengingDOM.clickOnBlueButton());

        //}


        [When(@"I click on delete")]
        public void WhenIClickOnDelete()
        {
            challengingDomPage.ClickDelete();
        }

        [Then(@"it should be clickable")]
        public void ThenItShouldBeClickable()
        {
            challengingDomPage.IsTheUserRedirectedToDeletePage().Should().BeFalse();
        }

        [Then(@"three buttons should be visible on the webpage")]
        public void ThenThreeButtonsShouldBeVisibleOnTheWebpage()
        {
            challengingDomPage.IsThreeButtonVisibleOnThePage().Should().BeTrue();
        }

        [Then(@"the colour should be red,blue and green")]
        public void ThenTheColourShouldBeRedBlueAndGreen()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
