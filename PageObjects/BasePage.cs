using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace TestAutomationFrontend.PageObjects;

public abstract class BasePage : PageTest
{
    protected readonly IPage _page;
    
    public BasePage(IPage page) => _page = page;
    
}
