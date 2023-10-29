// Pages/Blog/Show.cshtml.cs

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rezar.Pages.Blog;

public class ShowModel : PageModel
{
    private readonly ILogger<ShowModel> _logger;

    /*
     *
     * É necessário que os campos usados no HTML sejam propriedades
     * por isso o uso destas duas abaixo!.
     *
     */
    public string Title { get; set; } = default!;
    public string Body { get; set; } = default!;

    public ShowModel(ILogger<ShowModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(string title, string body)
    {
      /*
       * Atribuição das variáveis recebidas pela URL
       * ex: `/Blog/Show?title=salve&body=pessoal`
       */
        Title = title;
        Body = body;
    }
}

