using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFrontend.PageObjects;

public class IntroPage : BasePage
{
    public IntroPage(IPage page) : base(page) { }
    public async Task GotoIntroPage() => await  _page.GotoAsync("http://10.13.117.199:3000/");
    public ILocator OmitirBtn() => _page.GetByText("Omitir");
    public ILocator ComenzarBtn() => _page.GetByText("Comenzar");
    public ILocator WelcomeMessage() => _page.Locator(".h4Intro").First;

    
}
