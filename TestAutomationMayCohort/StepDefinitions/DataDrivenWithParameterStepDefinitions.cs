using System;
using TechTalk.SpecFlow;
using TestAutomationMayCohort.PageObject;

namespace TestAutomationMayCohort.StepDefinitions
{
    [Binding]
    public class DataDrivenWithParameterStepDefinitions
    {

        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterStepDefinitions()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }


        
        
        
        
        
        
        [Given(@"I navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }

        [Given(@"I enter my Username text ""([^""]*)""")]
        public void GivenIEnterMyUsernameText(string username)
        {
            dataDrivenWithParameterPage.EnterUsername(username);
        }

        [Given(@"I enter my email text ""([^""]*)""")]
        public void GivenIEnterMyEmailText(string email)
        {
            dataDrivenWithParameterPage.EnterEmail(email);
        }

        [Given(@"I enter my password text ""([^""]*)""")]
        public void GivenIEnterMyPasswordText(string password)
        {
            dataDrivenWithParameterPage.EnterPassword(password);
        }
    }
}
