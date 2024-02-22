using Microsoft.Playwright;
using System;
using TechTalk.SpecFlow;
using TestAutomationFrontend.PageObjects;
using Microsoft.Playwright.NUnit;

namespace TestAutomationFrontend.StepDefinitions
{
    [Binding]
    public class IntroPageStepDefinitions : BaseStepDefinitions
    {
        public IntroPageStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"I navigate to the site")]
        public async Task GivenINavigateToTheSite()
        {
            await IntroPage().GotoIntroPage();
        }

        [When(@"I click the skip button on intro page")]
        public async Task WhenIClickTheSkipButtonOnIntroPage()
        {
            await IntroPage().OmitirBtn().ClickAsync();
        }

        [When(@"I click the Login button")]
        public async Task WhenIClickTheLoginButton()
        {
            await InicioPage().IniciarBtn().ClickAsync();
        }

        [Then(@"I should see the Login page")]
        public async Task ThenIShouldSeeTheLoginPage()
        {
            await Expect(LoginPage().UsernameField()).ToBeVisibleAsync();
        }
    }
}
