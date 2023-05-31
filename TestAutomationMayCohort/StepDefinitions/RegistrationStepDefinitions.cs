using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomationMayCohort.PageObject;

namespace TestAutomationMayCohort.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {
        RegistrationPage registrationPage;

        public RegistrationStepDefinitions()
        {
            registrationPage = new RegistrationPage();
        
        }    






        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [Given(@"I click on Sign up")]
        public void GivenIClickOnSignUp()
        {
            registrationPage.ClickOnSignUp();
        }

        [Given(@"I enter my Username")]
        public void GivenIEnterMyUsername()
        {
            registrationPage.EnterUsername();
        }

        [Given(@"I enter my email")]
        public void GivenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }

        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            registrationPage.EnterPassword();

        }

        [When(@"I click on Sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            registrationPage.ClickOnSignUpButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegiserSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsNewArticleDisplayed);
        }
    }
}
