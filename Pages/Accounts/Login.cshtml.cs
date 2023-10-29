// Pages/Accounts/Login.cshtml.cs

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rezar.Pages.Accounts;

public class LoginModel : PageModel
{
    private readonly ILogger<LoginModel> _logger;

    public LoginModel(ILogger<LoginModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}

