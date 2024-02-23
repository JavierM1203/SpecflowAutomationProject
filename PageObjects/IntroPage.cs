using Microsoft.Playwright;

namespace TestAutomationFrontend.PageObjects;

public class IntroPage : BasePage
{
    public IntroPage(IPage page) : base(page) { }

    // Chane this URL to the corresponding URL of the site
    public string PageURL() => "http://localhost:3000/";
    public ILocator OmitirBtn() => _page.GetByText("Omitir");
    public ILocator ComenzarBtn() => _page.GetByText("Comenzar");
    public ILocator WelcomeMessage() => _page.Locator(".h4Intro").First;

    public async Task ClickOnOmitirBtn() => OmitirBtn().ClickAsync();

}
