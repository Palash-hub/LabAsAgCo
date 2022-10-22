using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Movie
{
    public String name { get; set; }

    public Movie(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return  name;
    }
}

