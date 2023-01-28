using System;

namespace Actividad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  
            // Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

            int numero, con = 0;

            Console.WriteLine("Ingrese el numero:");
            numero = int.Parse(Console.ReadLine());

            for (int x = 1; x <= numero; x++)
            {
                if (numero % x == 0)
                    con++; 
            }
            if(con == 2)
                Console.WriteLine("Es primo");
            else
                Console.WriteLine("No es primo");
            
            // CON WHILE
            
            // int numero, divisor = 1, con = 0;

            // Console.WriteLine("Ingrese el numero:");
            // numero = int.Parse(Console.ReadLine());

            // while (divisor <= numero)
            // {
            //     if (numero % divisor == 0){
            //         con++;
            //         divisor++;
            //     }else{
            //         divisor++;
            //     }    
            // }
            // if(con == 2){
            //     Console.WriteLine("Es primo");
            // }else{
            //     Console.WriteLine("No es primo");
            // }
        }
    }
}
