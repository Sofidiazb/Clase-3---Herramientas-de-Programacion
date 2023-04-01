using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clase3.Models;
using Clase3.Services;

namespace Clase3.Pages;


public class IndexModel : PageModel
{
    [BindProperty]
    public Movie NewMovie{ get;set; }
    public List<Movie> MovieList{ get;set; }
    public IndexModel()
    {
      
    }

    public void OnGet()
    {
        MovieList = MovieService.GetAll();
    }
    public IActionResult OnPost(){
        
        MovieService.Add(NewMovie);
        return RedirectToAction("get");
    }
}
