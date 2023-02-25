using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Directivos :Personas
    {
        public Directivos(string nombre, string apellido, string legajo, float sueldo)
            : base(nombre, apellido, legajo, sueldo)
        {

        }
    }
}
