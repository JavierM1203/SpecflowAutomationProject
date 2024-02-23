using Microsoft.Playwright;

namespace TestAutomationFrontend.PageObjects;

public class LoginPage : BasePage
{
    public LoginPage(IPage page) : base(page) { }

    public ILocator UsernameField() => _page.Locator(".MuiInputBase-inputAdornedStart.css-1o9s3wi-MuiInputBase-input-MuiOutlinedInput-input");
    public ILocator PasswordField() => _page.Locator(".MuiInputBase-inputAdornedEnd.css-152mnda-MuiInputBase-input-MuiOutlinedInput-input");
    public ILocator IniciarBtn() => _page.Locator(".MuiButton-containedSizeMedium.css-1pevvt3-MuiButtonBase-root-MuiButton-root");
    public ILocator ForgotPassBtn() => _page.Locator("[href=\"/Login\"]");
    public ILocator LoginErrorMessage() => throw new NotImplementedException("Login error message is not defined");

    public async Task EnterLoginCredentials(string username,  string password)
    {
        await UsernameField().FillAsync(username);
        await PasswordField().FillAsync(password);
    }

    public async Task ClickOnIniciarBtn() => await IniciarBtn().ClickAsync();

}
