using System;
using System.Collections.Generic;
using Entidades;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Adelantos a = new Adelantos("1234ABCD");
            Adelantos b = new Adelantos("123AABCD");
            Adelantos c = new Adelantos("12345BCD");
            Adelantos d = new Adelantos("1234AB-D");

            List<Adelantos> l = new List<Adelantos>();

            l.Add(a);

            l.Add(b);

            l.Add(c);

            l.Add(d);

            foreach(Adelantos i in l)
            {
                Console.WriteLine(i.Mostrar());
            }


            Console.ReadKey();
        }
    }
}
