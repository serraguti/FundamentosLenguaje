using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosLenguaje.Models
{
    //UN EMPLEADO HEREDA DE UNA PERSONA
    public class Empleado: Persona
    {
        public Empleado()
        {
            this.SalarioMinimo = 900;
        }

        public int Salario { get; set; }
        //EL EMPLEADO DEBE TENER UN SALARIO MINIMO
        protected int SalarioMinimo { get; set; }
    }
}
