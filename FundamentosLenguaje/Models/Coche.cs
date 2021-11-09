using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosLenguaje.Models
{
    public enum Brujula { Norte, Sur, Este, Oeste}

    public class Coche
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public int VelocidadActual { get; set; }

        public Brujula DireccionCoche { get; set; }
        //NECESITAMOS UNA VARIABLE PARA INDICAR
        //SI ESTAMOS ARRANCADOS O NO (DETENIDO)
        private bool EstadoArranque;
        //LA VELOCIDAD MAXIMA NO SE PODRA TOCAR
        private int VelocidadMaxima;
        //EN EL CONSTRUCTOR, INDICAMOS LA VELOCIDAD MAXIMA
        //DE CUALQUIER COCHE
        public Coche()
        {
            this.DireccionCoche = Brujula.Norte;
            this.EstadoArranque = false;
            this.VelocidadActual = 0;
            this.VelocidadMaxima = 190;
        }

        public Coche(int velocidadmaxima)
        {
            this.DireccionCoche = Brujula.Norte;
            this.EstadoArranque = false;
            this.VelocidadActual = 0;
            this.VelocidadMaxima = velocidadmaxima;
        }

        //METODO TOSTRING PARA DEVOLVER CARACTERISTICAS DEL COCHE
        public override string ToString()
        {
            return this.Marca + " " + this.Modelo + ", Velocidad: "
                + this.VelocidadActual + ", Dirección: "
                + this.DireccionCoche;
        }

        public void Arrancar()
        {
            this.EstadoArranque = true;
            Console.WriteLine("Coche arrancado");
        }

        public void Acelerar()
        {
            if (this.EstadoArranque == false)
            {
                //ESTAMOS PARADOS SIN ARRANCAR
                throw new Exception("No podemos acelerar sin arrancar");
            }
            else
            {
                //ACELERAMOS
                this.VelocidadActual += 20;
                //COMPROBAMOS LA VELOCIDAD DEL COCHE
                if (this.VelocidadActual > this.VelocidadMaxima)
                {
                    this.VelocidadActual = this.VelocidadMaxima;
                }
            }
        }

        public void Acelerar(int aceleracion)
        {
            if (this.EstadoArranque == false)
            {
                throw new Exception("El coche no puede acelerar sin estar arrancado");
            }
            else
            {
                this.VelocidadActual += aceleracion;
                if (this.VelocidadActual > this.VelocidadMaxima)
                {
                    this.VelocidadActual = this.VelocidadMaxima;
                }
            }
        }

        public void frenar()
        {
            this.VelocidadActual -= 20;
            if (this.VelocidadActual < 0)
            {
                this.VelocidadActual = 0;
            }
        }

        public void Girar()
        {
            if (this.DireccionCoche == Brujula.Norte)
            {
                this.DireccionCoche = Brujula.Sur;
            }else if (this.DireccionCoche == Brujula.Sur)
            {
                this.DireccionCoche = Brujula.Este;
            }else if (this.DireccionCoche == Brujula.Este)
            {
                this.DireccionCoche = Brujula.Oeste;
            }else
            {
                this.DireccionCoche = Brujula.Norte;
            }
        }
    }
}
