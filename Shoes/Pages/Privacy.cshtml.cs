﻿using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Shoes.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string title = "Privacy";
        ViewData["Title"] = title;

        string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
        ViewData["TimeStamp"] = dateTime;
    }
}


