using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Rezar.Pages.Accounts;

public class RegisterUserModel : PageModel{

    [BindProperty]
    public InputModel Input {get; set;} = default!;
    public class InputModel{
        [Required]
        public string Email {get; set;} = default!;

        [Required]
        public string Password {get; set;} = default!;
         
/*         [Required]
        [Compare("Password")]
        public string ConfirmPassword {get; set;} = default!; */
    }
    public void OnGet() { }
    public IActionResult OnPost(){
        if (!ModelState.IsValid)
        {
            return Page();
        }

        return RedirectToPage("/Blog/Show", new { title = Input.Email, body = Input.Password});
    }
}