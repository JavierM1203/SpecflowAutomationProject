using Microsoft.Playwright;

namespace TestAutomationFrontend.PageObjects;

public class LoginPage : BasePage
{
    public LoginPage(IPage page) : base(page) { }
    public ILocator UsernameField() => _page.Locator("#:r1:");
    public ILocator PasswordField() => _page.Locator("#:r3:");
    public ILocator IniciarBtn() => _page.Locator(":has-text(\"Iniciar\")");
    public ILocator WelcomeMessage() => _page.Locator(":has-text(\"Bienvenido\")");

    public async Task GotoLoginPage() => await _page.GotoAsync("Insert Login page URL");

    public async Task EnterLoginCredentials(string username,  string password)
    {
        await UsernameField().FillAsync(username);
        await PasswordField().FillAsync(password);
    }
}
