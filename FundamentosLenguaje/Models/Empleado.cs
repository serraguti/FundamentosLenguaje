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
            this.Salario = 900;
            Console.WriteLine("Constructor Empleado SIN PARAMETROS");
        }

        public Empleado(int salario)
        {
            Console.WriteLine("Constructor Empleado CON PARAMETROS");
        }

        public virtual int GetDiasVacaciones()
        {
            //EMPLEADO 22 DIAS
            return 50;
        }

        public override string ToString()
        {
            return this.Apellidos + " " + this.Nombre
                + ", Salario Minimo: " + this.SalarioMinimo;
        }


        //AHORA MISMO LO ESTAMOS SOBRESCRIBIENDO
        public override String GetNombreCompleto()
        {
            Console.WriteLine("GetNombreCompleto Empleado");
            return this.Nombre + " " + this.Apellidos 
                + ", Salario: " + this.Salario;
        }

        public int Salario { get; set; }
        //EL EMPLEADO DEBE TENER UN SALARIO MINIMO
        protected int SalarioMinimo { get; set; }
    }
}
