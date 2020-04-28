using System;

namespace unidad2tp2
{
    class Program

    {
        

        static void Main(string[] args)
        {
           
            Console.WriteLine("ingrese un numero para calcular iva :");
            int numero = Convert.ToInt32(Console.ReadLine());
            var calculo = numero * 1.21;
            Console.WriteLine("el precio sin iva es:"+ numero);
            Console.WriteLine("el precio con iva es:" + calculo);
            Console.Read();
           
        }
    }
}
