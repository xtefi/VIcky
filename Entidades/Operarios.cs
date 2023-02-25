using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operarios : Personas 
    {
        private string test;

        public string Test { get => test;  }
        public Operarios(string nombre, string apellido, string legajo, float sueldo)
            :base(nombre,apellido,legajo,sueldo)
        {
            this.test = "Hola";
        }
    }
}
