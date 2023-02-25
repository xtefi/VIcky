using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Adelantos
    {
        private DateTime fechaOtorga;
        private DateTime fechaDevuelve;
        private string codigo;
        private string monto;

        private List<Personas> beneficiarios;

        public string Codigo
        {
            get { return this.codigo; }
            set { if (ValidaCodigo(value)) this.codigo = value; }
        }

        public Adelantos(string codigo)
        {
            this.fechaOtorga = DateTime.Today;
            this.Codigo = codigo;
        }


        public bool ValidaCodigo (string ingreso)
        {
            try
            {
                if (ingreso.Length == 8)
                {
                    string auxiliarNumero = ingreso.Substring(0, 4);
                    string auxLetras = ingreso.Substring(4, 4);
                    if (auxiliarNumero.All(Char.IsDigit))
                    {
                        if (auxLetras.All(Char.IsLetter))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo; {this.Codigo}");
            return sb.ToString();

        }
    }
}
