using Microsoft.Playwright;

namespace TestAutomationFrontend.PageObjects;

public class LoginPage : BasePage
{
    public LoginPage(IPage page) : base(page) { }

    public ILocator UsernameField() => _page.Locator("#\\3Ar1\\3A");
    public ILocator PasswordField() => _page.Locator("#\\3Ar3\\3A");
    public ILocator IniciarBtn() => _page.Locator(".MuiButton-containedSizeMedium.css-1pevvt3-MuiButtonBase-root-MuiButton-root");


    public async Task EnterLoginCredentials(string username,  string password)
    {
        await UsernameField().FillAsync(username);
        await PasswordField().FillAsync(password);
    }
}
