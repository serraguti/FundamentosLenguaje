using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosLenguaje.Models
{
    public enum Paises { España, Francia, Alemania, Argentina }

    public class Persona
    {
        public Persona()
        {
            this.Edad = 10;
            this.Nacionalidad = Paises.España;
            Console.WriteLine("Constructor PERSONA");
        }
        //CONTROL + K + C
        //CONTROL + K + U

        public Persona(String nombre, String apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }



        //METODO ACCION PARA PONER EN MAYUSCULAS TODAS
        //LAS DESCRIPCIONES
        public void ConvertirDescripciones()
        {
            for (int i = 0; i < this._Descripciones.Length; i++)
            {
                this._Descripciones[i] = this._Descripciones[i].ToUpper();
            }
        }

        //METODOS QUE DEVUELVEN UN VALOR
        public virtual String GetNombreCompleto()
        {
            Console.WriteLine("GetNombreCompleto Persona");
            return this.Nombre + " " + this.Apellidos;
        }

        public void GetNombreCompleto(String algo)
        {
            
        }

        public String GetNombreCompleto(int num1, int num2)
        {
            return this.Nombre + " " + this.Apellidos;
        }
        public String GetNombreCompleto(int num)
        {
            return this.Nombre + " " + this.Apellidos;
        }

        //POLIMORFISMO
        public String GetNombreCompleto(bool orden)
        {
            if (orden == true)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else
            {
                return this.GetNombreCompleto();
            }
        }

        //PODEMOS MANEJAR LA PROPIEDAD INDIZADA CON
        //LISTAS (DINAMICA) O ARRAYS
        private string[] _Descripciones = new string[3];
        //PROPIEDAD INDIZADA
        public String this[int indice]
        {
            get {
                return this._Descripciones[indice];
            }
            set {
                this._Descripciones[indice] = value;
            }
        }

        public Paises Nacionalidad { get; set; }

        //MENOS MAL QUE TENEMOS LA POSIBILIDAD DE DECLARAR PROPIEDADES
        //DE UNA FORMA SENCILLA SI NO DESEAMOS CONTROLAR NADA

        public String Nombre { get; set; }
        public String Apellidos { get; set; }

        //CUANDO SE TRABAJA CON PROPIEDADES
        //SIEMPRE SE UTILIZA LO QUE SE LLAMA
        //UN CAMPO DE PROPIEDAD.
        //UN CAMPO DE PROPIEDAD ES UNA VARIABLE PARA
        //DEVOLVER O UTILIZAR EN LA PROPIEDAD
        // _Propiedad
        //DEBE SER PRIVADO
        private int _Edad;
        //DECLARAMOS UNA PROPIEDAD Edad
        public int Edad
        {
            get {
                //EN EL Get() SE DEVUELVE EL VALOR
                return this._Edad;
            }
            set {
                //ENTRA CUANDO CAMBIAMOS EL VALOR DE LA PROPIEDAD
                //SE ALMACENA EL NUEVO VALOR CON value
                //AHORA PODEMOS COMPROBAR LOS VALORES DE value
                if (value < 0)
                {
                    //HACEMOS ALGO, ERROR??
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    //TODO OK
                    this._Edad = value;
                }
            }
        }
    }
}
