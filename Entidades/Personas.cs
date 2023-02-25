using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Personas
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private float sueldo;
        public List<Adelantos> adelantos;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Legajo { get { return legajo; } set { legajo = value; } }
        public float Sueldo { get { return sueldo; } set { sueldo = value; } }

        public Personas(string nombre, string apellido, string legajo, float sueldo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Legajo = legajo;
            this.Sueldo = sueldo;
            this.adelantos = new List<Adelantos>();
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Nombre: {this.apellido}");
            return sb.ToString();
        }

    }
}
