using FundamentosLenguaje.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosLenguaje.Helpers
{
    public class HelperMeses
    {
        //ESTA CLASE TENDRA UNA SERIE DE MESES (12)
        //DECLARAMOS UNA PROPIEDAD PARA MANEJAR LOS MESES
        public List<TemperaturaMes> Meses { get; set; }
        /// <summary>
        /// COMENTARIOS DE LA CLASE
        /// </summary>
        #region ZONA CONSTRUCTOR

        //AL INSTANCIAR LA CLASE, QUEREMOS TENER
        //YA LOS MESES CREADOS
        public HelperMeses()
        {
            //CREAMOS/INSTANCIAMOS LA COLECCION DE MESES
            this.Meses = new List<TemperaturaMes>();
            Random random = new Random();
            //REALIZAMOS EL CODIGO PARA ALMACENAR MESES
            for (int i = 1; i <=12; i++)
            {
                TemperaturaMes mes = new TemperaturaMes();
                mes.Mes = "Mes " + i;
                mes.Maxima = random.Next(20, 50);
                mes.Minima = random.Next(-10, 20);
                this.Meses.Add(mes);
            }
        }

        #endregion

        //QUEREMOS UN METODO QUE NOS DIGA LA MAXIMA ANUAL
        public int GetMaximaAnual()
        {
            //DEBEMOS RECORRER TODOS LOS MESES Y
            //VER EL VALOR MAXIMO DE CADA MES
            int maxima = 0;
            foreach (TemperaturaMes mes in this.Meses)
            {
                maxima = Math.Max(maxima, mes.Maxima);
            }
            return maxima;
        }

        public int GetMinimaAnual()
        {
            int minima = 30;
            foreach (TemperaturaMes mes in this.Meses)
            {
                minima = Math.Min(minima, mes.Minima);
            }
            return minima;
        }

        public int GetMediaAnual()
        {
            int media = 0;
            foreach (TemperaturaMes mes in this.Meses)
            {
                media += mes.GetMedia();
            }
            return media / this.Meses.Count;
        }
    }
}
