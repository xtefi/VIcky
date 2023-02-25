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
        private float monto;
        public List<Personas> beneficiarios;
        private Personas persona;

        public string Codigo
        {
            get { return codigo; }
            set { if (ValidaCodigo(value)) this.codigo = value; }
        }

        public float Monto 
        {
            get { return monto; }
            set { if (ValidaMonto(persona, value)) this.monto = value; }
        }

        public Adelantos(string codigo, Personas persona)
        {
            this.fechaOtorga = DateTime.Today;
            this.Codigo = codigo;
            this.fechaDevuelve = DateTime.MinValue;
            this.beneficiarios = new List<Personas>();
            this.persona = persona;
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

        //El importe asignado en un adelanto no puede superar el 50% del sueldo del beneficiario
        //y la sumatoria del dinero de los adelantos asignados y no devueltos no puede superar
        //el sueldo del empleado.
        private bool ValidaMonto(Personas p, float monto)
        {
            float auxiliar=0;
            if(p is not null && monto <= (p.Sueldo * 0.5)) //Chequea que el importe no supere 50% del sueldo
            {
                foreach(Adelantos item in p.adelantos)
                {
                    if(item.fechaDevuelve != DateTime.MinValue) //Chequea que el adelanto no tenga fecha de devolucion
                    {
                        auxiliar += item.monto;
                    }                    
                }
                auxiliar += monto;
                if(auxiliar <= p.Sueldo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator +(Adelantos a, Personas p)
        {
            if (p.adelantos.Count < 3)
            {
                a.beneficiarios.Add(p);
                a.beneficiarios.Add(p);
            }
            return true;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo: {this.Codigo}");
            return sb.ToString();
        }
    }
}
