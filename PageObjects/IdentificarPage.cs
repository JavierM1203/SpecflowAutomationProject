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

    public async Task ClickOnTakePictureBtn() => await TakePictureBtn().ClickAsync();

    public async Task AssertSubirBtnIsVisible() => await SubirBtn().IsVisibleAsync();

}
