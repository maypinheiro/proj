using System;
using proj.Entities;

namespace proj
{
    class Program
    {
        static  void Main(string[] args)
        {
          Clients clienteUm = new Clients{Name = "Mayara", Email = "mayara@hotmail.com"};
          Clients clienteDois = new Clients{Name = "may", Email = "may@hotmail.com"};

            System.Console.WriteLine(clienteUm.Equals(clienteDois));
       
        }


    }
}
