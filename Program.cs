using System;

namespace Ejercicio2DeFacundoGiannone
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            try
            {
                Console.WriteLine("Ingresar el valor del termino cuadratico A: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar el valor del termino cuadratico B: ");
                b = int.Parse(Console.ReadLine());

                if (((a == 0) && (b != 0)) || ((a != 0) && (b == 0)))
                {
                    Console.WriteLine("Esta conica es una parabola.");
                }
                if ((((a != 0) && (((b != 0)))) && (a == b)))
                {
                    Console.WriteLine("Esta conica es una circunferencia.");
                }
                if  ((((((a!=0) && (b!=0)) && ((((a<0) && (b<0))))) || ((a>0) && (b>0)))) && (a!=b))    
                {
                    Console.WriteLine("Esta conica es una elipse.");
                }
                if ((((((a != 0) && (b != 0)) && ((((a > 0) && (b < 0))))) || ((a < 0) && (b > 0)))) && (a != b))
                {
                    Console.WriteLine("Esta conica es una hiperbola.");

                }
                if ((a == 0) && (b == 0))
                {
                    Console.WriteLine("Los valores ingresados no conforman una conica");
                }
            } catch (Exception) {
                Console.WriteLine("Los valores ingresados son incorrectos");
            }
        }
    }
}
