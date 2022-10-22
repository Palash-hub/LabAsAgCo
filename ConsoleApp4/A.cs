using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class A
{
    public B b;

    public A()
    {
        //this.b = new B();
    }

    public B B
    {
        get => default;
        set
        {
        }
    }

    public void PropertyA() { }



    public void Add(B b)
    {
        this.b = b;
    }
}