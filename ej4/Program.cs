using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba
            // un número por valor y una variable por referencia. Que analice el número y escriba variable recibida
            // por referencia con:

            // a. 1 si el número es positivo.
            // b. -1 si el número es negativo.
            // c. 0 si el número es cero.

            int n, situacion=0;

            Console.WriteLine("Ingrese un nro: ");
            n = int.Parse(Console.ReadLine());

            positivoNegativoCero(n, ref situacion);

            if(situacion ==0)
                Console.WriteLine("El nro es cero");
                else if(situacion == 1)
                    Console.WriteLine("El nro es positivo");
            else
                Console.WriteLine("El nro es negativo");

        }

        static void positivoNegativoCero(int a, ref int b){
            if (a == 0)
                b = 0;
                else if(a>0)
                    b = 1;
            else 
                b = -1;

        }
    }
}
