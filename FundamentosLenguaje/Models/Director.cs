using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosLenguaje.Models
{
    public class Director: Empleado
    {
        //UN EMPLEADO DEBERIA COBRAR LO MISMO QUE UN DIRECTOR??
        //VAMOS A CAMBIAR EL SalarioMinimo DE DIRECTOR EN SU CONSTRUCTOR
        public Director()
        {
            //NO PODEMOS PORQUE ES PRIVATE
            this.SalarioMinimo = 1400;
        }
    }
}
