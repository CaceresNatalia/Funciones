using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
            // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla
            // el monto total a pagar. Usar la función.

            int precio, totalVenta, cantidad;
            
            Console.WriteLine("Ingrese la cantidad vendida:");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio:");
            precio = int.Parse(Console.ReadLine());

            totalVenta = producto(cantidad, precio);

            Console.WriteLine("El monto a pagar por su compra es de $" + totalVenta);


        }

        static int producto(int a, int b){
            return a * b;
        
        }
    }
}
