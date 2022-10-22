using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cinema
{
    public string Name { get; set; }

    List<Movie> movies = new List<Movie>();

    public Cinema(string name)
    {
        Name = name;
    }
    public Cinema() { }

    //private Cinema(Cinema cinema)
    //{
    //    this.Name = cinema.Name;
    //    this.movies = cinema.movies;
    //}

    public void AddMovie(Movie movie)
    {
        movies.Add(movie);
    }

    public void NewMovie(String movie)
    {
        Movie movie1 = new Movie(movie);
        movies.Add(movie1);
    }

    public Cinema Clone()
    {
        return new Cinema()
        {
            Name = this.Name,
            movies = this.movies
        };
    }

    public void ToString()
    {
        Console.Write(Name + " { ");
        foreach(Movie movie in movies)
        {
            Console.Write(movie.ToString()+"; ");
        }
        Console.Write("}");
    }
}
