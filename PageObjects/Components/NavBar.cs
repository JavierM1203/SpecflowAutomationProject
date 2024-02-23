using Microsoft.Playwright;

namespace TestAutomationFrontend.PageObjects.Components;

public class NavBar : BasePage
{
    public NavBar(IPage page) : base(page) { }

    public ILocator IdentificarBtn() => _page.Locator("[href=\"/identificar\"]");
    public ILocator GuardadosBtn() => _page.Locator("[href=\"/guardados\"]");
    public ILocator ForoBtn() => _page.Locator("[href=\"/foro\"]");
    public ILocator PerfilBtn() => _page.Locator("[href=\"/perfil\"]");

}
