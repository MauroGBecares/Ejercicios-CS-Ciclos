using System;

namespace Actividad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

            int edad;
            float promedio;
            int acu = 0;
            int con = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese una edad:");
                edad = int.Parse(Console.ReadLine());
                if(edad > 18){
                    acu += edad;
                    con++; 
                }
            }
            promedio = acu / con;
            Console.WriteLine("El promedio de las personas con edad mayor a 18 es: " + promedio.ToString("0.00"));
        }
    }
}
