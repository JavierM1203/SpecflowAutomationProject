using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using TestAutomationFrontend.PageObjects;

namespace TestAutomationFrontend.StepDefinitions;

public abstract class BaseStepDefinitions : PageTest
{
    protected readonly IPage _page;

    public BaseStepDefinitions(ScenarioContext scenarioContext) => _page = scenarioContext["page"] as IPage;
    
    public IntroPage IntroPage() => new IntroPage(_page);
    public InicioPage InicioPage() => new InicioPage(_page);
    public LoginPage LoginPage() => new LoginPage(_page);
    public ForoPage ForoPage() => new ForoPage(_page);
}
