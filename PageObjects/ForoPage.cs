using Microsoft.Playwright;

namespace TestAutomationFrontend.PageObjects;

public class ForoPage : BasePage
{
    public ForoPage(IPage page) : base(page) { }

    public ILocator WelcomeMessage() => _page.Locator(".foro");
    public ILocator Identificar() => _page.Locator("[href=\"/identificar\"]");
}
