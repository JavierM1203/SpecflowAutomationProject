using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFrontend.PageObjects;

public class IdentificarPage : BasePage
{
    public IdentificarPage(IPage page) : base(page) { }

    public ILocator TakePictureBtn() => _page.Locator("#inner-circle");
    public ILocator SubirBtn() => _page.Locator("//button[2]");
    public ILocator ConfirmarBtn() => _page.GetByText("Confirmar");
    public ILocator ModificarBtn() => _page.GetByText("Modificar");
    public ILocator RecognizedDeviceMessage() => _page.Locator("#alert-dialog-description");
    public ILocator TipoSelect() => _page.Locator("#tipo-select");
    public ILocator MarcaSelect() => _page.Locator("#marca-select");
    public ILocator ModeloSelect() => _page.Locator("#modelo-select");

    public async Task ClickOnTakePictureBtn() => await TakePictureBtn().ClickAsync();

    public async Task AssertSubirBtnIsVisible() => await SubirBtn().IsVisibleAsync();
    public async Task AssertRecognizedDeviceIsVisible() => await RecognizedDeviceMessage().IsVisibleAsync();

    public async Task AssertModifyResultIsVisible()
    {
        await Expect(TipoSelect()).ToBeVisibleAsync();
        await Expect(MarcaSelect()).ToBeVisibleAsync();
        await Expect(ModeloSelect()).ToBeVisibleAsync();
    }

}
