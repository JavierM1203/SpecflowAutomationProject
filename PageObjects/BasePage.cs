﻿using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFrontend.PageObjects;

public abstract class BasePage
{
    protected readonly IPage _page;
    public BasePage(IPage page) => _page = page;
    
}
