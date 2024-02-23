using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using TestAutomationFrontend.PageObjects;
using TestAutomationFrontend.PageObjects.Components;

namespace TestAutomationFrontend.StepDefinitions;

public abstract class BaseStepDefinitions : PageTest
{
    protected readonly IPage _page;

    public BaseStepDefinitions(ScenarioContext scenarioContext) => _page = scenarioContext["page"] as IPage;

    public IntroPage IntroPage() => new IntroPage(_page);
    public InicioPage InicioPage() => new InicioPage(_page);
    public LoginPage LoginPage() => new LoginPage(_page);
    public SignUpPage SignUpPage() => new SignUpPage(_page);
    public NavBar NavBar() => new NavBar(_page);
    public ForoPage ForoPage() => new ForoPage(_page);
    public IdentificarPage IdentificarPage() => new IdentificarPage(_page);

    public async Task GotoIntroPage() => await _page.GotoAsync(IntroPage().PageURL());

    public async Task GotoLoginPage()
    {
        await GotoIntroPage();
        await IntroPage().ClickOnOmitirBtn();
        await InicioPage().IniciarBtn().ClickAsync();
    }
}
