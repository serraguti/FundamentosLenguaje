using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosLenguaje.Models
{
    public class Director: Empleado
    {
        public Director()
        {
            //NO PODEMOS PORQUE ES PRIVATE
            this.SalarioMinimo = 1400;
            Console.WriteLine("Constructor Director SIN PARAMETROS");
        }

        //AUNQUE TENGAMOS OTROS CONSTRUCTOR DENTRO DE DIRECTOR
        //TODO SIGUE IGUAL
        //SI DESEAMOS LLAMAR A ALGUN CONSTRUCTOR DE FORMA 
        //EXPLICITA, DEBEMOS HACERLO CON :base
        public Director(int salario):base(12)
        {
            Console.WriteLine("Constructor Director CON PARAMETROS");
        }

        public override int GetDiasVacaciones()
        {
            //LLAMAMOS AL METODO DE EMPLEADO Y RECOGEMOS
            //SU VALOR
            int diasempleado = base.GetDiasVacaciones();
            return diasempleado + 20;
        }

        //UN EMPLEADO DEBERIA COBRAR LO MISMO QUE UN DIRECTOR??
        //VAMOS A CAMBIAR EL SalarioMinimo DE DIRECTOR EN SU CONSTRUCTOR
    }
}
