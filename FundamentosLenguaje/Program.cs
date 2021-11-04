using System;

namespace FundamentosLenguaje
{
    class Program
    {
        static void Main(string[] args)
        {
            //DESDE AQUI EJECUTAMOS EL METODO
            //NumeroPositivoNegativo();
            //ESTO es un cambio
            MayorTresNumeros();
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
