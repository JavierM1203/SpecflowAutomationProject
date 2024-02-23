using System;
using TechTalk.SpecFlow;
using Microsoft.Playwright;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private IBrowser _browser;
        private IPage _page;
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public async Task BeforeScenario()
        {
            var playwright = await Playwright.CreateAsync();
            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = true,
                Channel = "chrome",
            });
            _page = await _browser.NewPageAsync();
            _scenarioContext["page"] = _page;
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            await _page.CloseAsync();
            await _browser.CloseAsync();
        }
    }

}