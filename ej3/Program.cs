using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número
            // es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se
            // ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

            int n, promedio, acu=0, con=0;
            Console.WriteLine("Ingrese un nro:");
            n = int.Parse(Console.ReadLine());

            while (n!=0){
            
            

            if (esPrimo(n)){
                acu+=n;
                con++;
            }

            n = int.Parse(Console.ReadLine());


            }

            promedio = acu/con;

            Console.WriteLine("El promedio de los nros primos es " + promedio);

        }

        static bool esPrimo(int a){
            int con=0;
            for (int x=1; x<=a; x++){
                
                if(a%x==0)
                    con++;
            }

            if (con==2)
                return true;
            else
                return false;
        }
    }
}
