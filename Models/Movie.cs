using System.ComponentModel.DataAnnotations;

namespace Clase3.Models;

public class Movie{
    public string Code { get;set; }

    [Display(Name ="Nombre")]
    public string Name { get;set; }
    public int Minutos { get;set; }
    public string Category { get;set; }
    public string Review { get;set; }
}