using Microsoft.Playwright;

namespace TestAutomationFrontend.PageObjects;

public class SignUpPage : BasePage
{
    public SignUpPage(IPage page) : base(page) { }

    public ILocator UsernameField() => _page.Locator("#\\3Ar1\\3A");
    public ILocator EmailField() => _page.Locator("#\\3Ar3\\3A");
    public ILocator PasswordField() => _page.Locator("#\\3Ar5\\3A");
    public ILocator RepeatPasswordField() => _page.Locator("#\\3Ar7\\3A");
    public ILocator CreateBtn() => _page.Locator("Crear Cuenta");
    public ILocator CancelarBtn() => _page.GetByText("Cancelar");

    public async Task EnterAccountInfo(string username, string email, string  password, string repeatPassword)
    {
        await UsernameField().FillAsync(username);
        await EmailField().FillAsync(email);
        await PasswordField().FillAsync(password);
        await RepeatPasswordField().FillAsync(repeatPassword);
    }

    public async Task ClickOnCreateBtn()
    {
        await CreateBtn().ClickAsync();
    }


}
