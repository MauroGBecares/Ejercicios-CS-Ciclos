using System;

namespace Actividad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

            int numero, maxN = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero:");
                numero = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    maxN = numero;
                }else if(numero > maxN)
                    maxN = numero;
            }
            Console.WriteLine("El numero maximo ingresado es: " + maxN);
        }
    }
}
