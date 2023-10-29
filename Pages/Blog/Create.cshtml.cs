// Pages/Blog/Create.cshtml.cs

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rezar.Pages.Blog;

public class CreateModel : PageModel
{
    private readonly ILogger<CreateModel> _logger;

    public CreateModel(ILogger<CreateModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public InputModel Input { get; set; } = default!;

    public class InputModel
    {
        [Required]
        [Display(Name = "Título")]
        public string Title { get; set; } = default!;

        [Required]
        [Display(Name = "Conteúdo")]
        public string Body { get; set; } = default!;

    }

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        return RedirectToPage("./Show", new { title = Input.Title, body = Input.Body });
    }
}

