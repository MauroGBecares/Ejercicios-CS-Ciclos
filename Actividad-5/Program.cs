using System;

namespace Actividad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
            
            int numero, maxP = 0, minI = 0;
            bool b1 = false, b2 = false;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero:");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    if (!b1)
                    {
                        maxP = numero;
                        b1 = true;
                    }
                    else if (numero > maxP) 
                    {
                        maxP = numero;
                    }
                    
                }
                else if (!b2)
                    {
                        minI = numero;
                        b2 = true;
                    }
                    else if (numero < minI)
                    {
                        minI = numero;
                    }  
                    
            }
            Console.WriteLine("El maximo de los pares es: " + maxP);
            Console.WriteLine("El minimo de los impares es: " + minI);
        }
    }
}
