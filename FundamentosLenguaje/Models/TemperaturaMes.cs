﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosLenguaje.Models
{
    public class TemperaturaMes
    {
        public int Maxima { get; set; }
        public int Minima { get; set; }
        public String Mes { get; set; }

        //NECESITAMOS CALCULAR LA MEDIA
        public int GetMedia()
        {
            return (this.Maxima + this.Minima) / 2;
        }
    }
}
