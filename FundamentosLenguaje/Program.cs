using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using FundamentosLenguaje.Helpers;
using FundamentosLenguaje.Models;

namespace FundamentosLenguaje
{
    enum TipoChar { Letras, Numeros, Simbolos}
    class Program
    {
        static void Main(string[] args)
        {
            Coche car = new Coche();
            int opcion = -1;
            while (opcion != 6)
            {
                MostrarMenuCoche();
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    car.Arrancar();
                }else if (opcion == 2)
                {
                    car.Acelerar();
                }else if (opcion == 3)
                {
                    car.frenar();
                }else if (opcion == 4)
                {
                    car.Girar();
                }else if (opcion == 5)
                {
                    Console.WriteLine("Aceleración");
                    int aceleracion = int.Parse(Console.ReadLine());
                    car.Acelerar(aceleracion);
                }else if (opcion == 6)
                {
                    Console.WriteLine("Hasta luego");
                }
                else
                {
                    Console.WriteLine("Opción incorrecta");
                }
                Console.WriteLine(car.ToString());
            }
            Console.WriteLine("Fin de programa");
        }

        static void MostrarMenuCoche()
        {
            Console.WriteLine("-----------MENU-----------");
            Console.WriteLine("1.- Arrancar");
            Console.WriteLine("2.- Acelerar");
            Console.WriteLine("3.- Frenar");
            Console.WriteLine("4.- Girar");
            Console.WriteLine("5.- Acelerar personalizado");
            Console.WriteLine("6.- Salir");
            Console.WriteLine("Seleccione una opción");
        }

        static void EjemploMeses()
        {
            //CREAMOS LA CLASE QUE ADMINISTRA MESES
            HelperMeses helper = new HelperMeses();
            //AQUI YA SE HAN CREADO LOS MESES
            //VAMOS A DIBUJARLOS
            foreach (TemperaturaMes mes in helper.Meses)
            {
                Console.WriteLine(mes.Mes + ", Maxima: "
                    + mes.Maxima + ", Minima: "
                    + mes.Minima + ", Media Mensual: "
                    + mes.GetMedia());
            }
            //MOSTRAMOS LOS DATOS DE MAXIMA ANUAL, MINIMA Y MEDIA
            Console.WriteLine("------------DATOS ANUALES-------------");
            Console.WriteLine("Maxima Anual " + helper.GetMaximaAnual());
            Console.WriteLine("Minima Anual " + helper.GetMinimaAnual());
            Console.WriteLine("Media Anual " + helper.GetMediaAnual());
            Console.WriteLine("Fin de programa");
        }

        static void EjemploColecciones()
        {
            List<int> numeros = new List<int>();
            //AL TENER TIPADO, NOS DA ERRORES DE COMPILACION
            numeros.Add(45);
            numeros.Add(78);
            //foreach (int num in numeros)
            //{
            //    Console.WriteLine(num);
            //}

            List<String> nombres = new List<string>();
            nombres.Add("Ana");
            nombres.Add("Adrian");
            nombres.Add("Lucia");
            nombres.Add("Ana");
            //QUE SUCEDE SI ELIMINAMOS UN ELEMENTO REPETIDO
            //POR SU OBJETO
            //ELIMINA LA PRIMERA COINCIDENCIA
            //nombres.Remove("Ana");
            //PODEMOS ELIMINAR POR INDICE
            nombres.RemoveAt(3);
            //Console.WriteLine(nombres[1]);
            int longitud = nombres.Count;
            for (int i = 0; i < longitud; i++)
            {
                nombres.Add("Otro nombre");
            }
        }

        static void InvertirTextoStringBuilder(String datos)
        {
            //QUEREMOS MEDIR EL RENDIMIENTO
            Stopwatch krono = new Stopwatch();
            //INICIAMOS EL CONTADOR
            krono.Start();
            //TRABAJAMOS CON STRINGBUILDER
            StringBuilder texto = new StringBuilder();
            texto.Append(datos);
            //AÑADIMOS EL TEXTO AL BUILDER
            //RECORREMOS EL TEXTO
            for (int i = 0; i < texto.Length; i++)
            {
                //RECUPERAMOS LA ULTIMA LETRA
                char letra = texto[texto.Length - 1];
                //ELIMINAMOS LA ULTIMA LETRA
                texto = texto.Remove(texto.Length - 1, 1);
                //INSERTAMOS LA LETRA EN LA POSICION DE i
                texto = texto.Insert(i, letra.ToString());
            }
            Console.WriteLine("---------------------------------");
            krono.Stop();
            Console.WriteLine(texto);
            Console.WriteLine("------------TIEMPO-----------------");
            Console.WriteLine("Milisegundos: " + krono.Elapsed.TotalMilliseconds);
        }

        static void InvertirTextoString(String texto)
        {
            //QUEREMOS MEDIR EL RENDIMIENTO
            Stopwatch krono = new Stopwatch();
            //INICIAMOS EL CONTADOR
            krono.Start();
            //RECORREMOS EL TEXTO
            for (int i = 0; i < texto.Length; i++)
            {
                //RECUPERAMOS LA ULTIMA LETRA
                char letra = texto[texto.Length - 1];
                //ELIMINAMOS LA ULTIMA LETRA
                texto = texto.Remove(texto.Length - 1, 1);
                //INSERTAMOS LA LETRA EN LA POSICION DE i
                texto = texto.Insert(i, letra.ToString());
            }
            Console.WriteLine("---------------------------------");
            krono.Stop();
            Console.WriteLine(texto);
            Console.WriteLine("------------TIEMPO-----------------");
            Console.WriteLine("Milisegundos: " + krono.Elapsed.TotalMilliseconds);
        }

        static void SumarNumerosString()
        {
            Console.WriteLine("Introduzca un texto");
            string texto = Console.ReadLine();
            int suma = 0;
            for (var i = 0; i < texto.Length; i++)
            {
                //PROPIEDAD INDIZADA DE UN CONJUNTO
                char caracter = texto[i];
                //CONVERTIMOS EL CARACTER A NUMERO
                //EN ESTA CONVERSION RECUPERA EL CODIGO
                //ASCII DEL NUMERO '1' (49)
                //NO NOS SIRVE ESTA CONVERSION
                //int numero = (int)caracter;
                //DEBEMOS CONVERTIR EL CARACTER A LITERAL (String)
                int numero = int.Parse(caracter.ToString());
                suma += numero;
            }
            Console.WriteLine(suma);
        }

        static void EjemploChar(TipoChar tipo)
        {
            for (int i = 0; i <= 255; i++)
            {
                char letra = (char) i;
                if (tipo == TipoChar.Simbolos)
                {
                    if (char.IsSymbol(letra))
                    {
                        Console.WriteLine(letra);
                    }
                }else if (tipo == TipoChar.Letras)
                {
                    if (char.IsLetter(letra))
                    {
                        Console.WriteLine(letra);
                    }
                }else if (tipo == TipoChar.Numeros)
                {
                    if (char.IsNumber(letra))
                    {
                        Console.WriteLine(letra);
                    }
                }
            }
        }

        static void SumarNumeros()
        {
            Console.WriteLine("Introduzca un número");
            String dato = Console.ReadLine();
            int numero = int.Parse(dato);
            int suma = numero;
            while (numero != 0)
            {
                Console.WriteLine("Suma " + suma);
                Console.WriteLine("Introduzca numero");
                dato = Console.ReadLine();
                numero = int.Parse(dato);
                suma += numero;
            }
            Console.WriteLine("Hasta luego");
        }

        static void NumerosPares()
        {
            Console.WriteLine("Introduzca un inicio: ");
            String dato = Console.ReadLine();
            int inicio = int.Parse(dato);
            Console.WriteLine("Introduzca un fin: ");
            dato = Console.ReadLine();
            int fin = int.Parse(dato);
            for (int i = inicio; i <= fin; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
        }

        static void ConjeturaCollatz()
        {
            Console.WriteLine("Introduzca un número");
            String dato = Console.ReadLine();
            int numero = int.Parse(dato);
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    //PAR
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                Console.WriteLine(numero);
            }
        }

        static void DiaNacimientoSemana()
        {
            Console.WriteLine("Dia");
            String dato = Console.ReadLine();
            int dia = int.Parse(dato);
            Console.WriteLine("Mes");
            dato = Console.ReadLine();
            int mes = int.Parse(dato);
            Console.WriteLine("Año");
            dato = Console.ReadLine();
            int anyo = int.Parse(dato);
            if (mes == 1)
            {
                mes = 13;
                anyo -= 1;
            }else if (mes == 2)
            {
                mes = 14;
                anyo -= 1;
            }
            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anyo / 4;
            int op3 = anyo / 100;
            int op4 = anyo / 400;
            //5.	Sumar el dia, el doble del mes, 
            //el año, el resultado de la operación 1, 
            //el resultado de la operación 2, 
            //menos el resultado de la operación 3 más la operación 4 más 2.
            int op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int resultado = op5 - (op6 * 7);
            if (resultado == 0)
            {
                Console.WriteLine("SABADO");
            }else if (resultado == 1)
            {
                Console.WriteLine("DOMINGO");
            }else if ( resultado == 2)
            {
                Console.WriteLine("LUNES");
            }else if (resultado == 3)
            {
                Console.WriteLine("MARTES");
            }else if (resultado == 4)
            {
                Console.WriteLine("MIERCOLES");
            }else if ( resultado == 5)
            {
                Console.WriteLine("JUEVES");
            }else if (resultado == 6)
            {
                Console.WriteLine("VIERNES");
            }
            else
            {
                Console.WriteLine("RESULTADO INCORRECTO");
            }
        }

        static void MayorTresNumeros()
        {
            Console.WriteLine("Número 1: ");
            string dato = Console.ReadLine();
            int numero1 = int.Parse(dato);
            Console.WriteLine("Número 2: ");
            dato = Console.ReadLine();
            int numero2 = int.Parse(dato);
            Console.WriteLine("Número 3: ");
            dato = Console.ReadLine();
            int numero3 = int.Parse(dato);
            int mayor = 0, menor = 0, intermedio = 0;
            if (numero1 >= numero2 && numero1 >= numero3) {
                mayor = numero1;
            }else if (numero2 >= numero1 && numero2 >= numero3)
            {
                mayor = numero2;
            }
            else
            {
                mayor = numero3;
            }
            if (numero1 <= numero2 && numero1 <= numero3)
            {
                menor = numero1;
            }else if (numero2 <= numero1 && numero2 <= numero3)
            {
                menor = numero2;
            }
            else
            {
                menor = numero3;
            }
            int suma = (numero1 + numero2 + numero3);
            intermedio = suma - mayor - menor;
            Console.WriteLine("Número mayor: " + mayor);
            Console.WriteLine("Número menor: " + menor);
            Console.WriteLine("Intermedio: " + intermedio);
        }

        static void NumeroPositivoNegativo() {
            Console.WriteLine("Introduzca un número");
            //RECUPERO EL VALOR EN UNA VARIABLE STRING
            String dato = Console.ReadLine();
            //DECLARAMOS UN int PARA CONVERTIR EL DATO
            int numero = int.Parse(dato);
            //EVALUAMOS CON UNA CONDICION POSITIVO, NEGATIVO O CERO
            if (numero > 0)
            {
                Console.WriteLine("POSITIVO");
            }else if (numero == 0)
            {
                Console.WriteLine("CERO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}
