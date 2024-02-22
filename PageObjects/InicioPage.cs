using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFrontend.PageObjects;

public class InicioPage : BasePage
{
    public InicioPage(IPage page) : base(page) { }

    public ILocator CrearCuentaBtn() => _page.GetByText(".MuiButton-outlinedSizeMedium.css-y96evj-MuiButtonBase-root-MuiButton-root");
    public ILocator IniciarBtn() => _page.Locator(".MuiButton-containedSizeMedium.css-flo6pn-MuiButtonBase-root-MuiButton-root");


}
