using Clase3.Models;

namespace Clase3.Services;

public static class MovieService{
    static List<Movie> Movies { get;set; }
    static MovieService(){
        Movies = new List<Movie>{
            new Movie {Name = "Batman", Code = "BTM", Minutos = 150, Category = "Ciencia Ficcion", Review = "Muy buena."},
            new Movie {Name = "Tarzan", Code = "TRZ", Minutos = 120, Category = "Ciencia Ficcion", Review = "Muy buena."},
            new Movie {Name = "Avatar", Code = "BTM", Minutos = 350, Category = "Ciencia Ficcion", Review = "Muy larga."}
        };
    }
    public static List<Movie> GetAll() => Movies;
    public static void Add(Movie obj){
        if (obj == null){
            return;
        } else{
            Movies.Add(obj);
        }
        
    }
    public static void Delete(string code){
        var movieToDelete = Get(code);
        if(movieToDelete != null){
            Movies.Remove(movieToDelete);
        }
    }
    public static Movie? Get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());
}

