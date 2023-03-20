using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
        //    2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
        //    Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

        int n, con=0, par=0;

        for (int x = 0; x < 5; x++){

            Console.WriteLine("ingrese un nro: " );
            n = int.Parse(Console.ReadLine());

            par = esPar(n);
            if (par==1)
                con++;
            
        }
        Console.WriteLine("Se ingresaron " + con + " nros pares.");

        }

        static int esPar(int a){
            if (a%2==0)
                return 1;
            else
                return 0;
        }
    }
}
