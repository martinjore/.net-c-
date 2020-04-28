using System;

namespace funcion
{
    class Program
    {
        public static void CalcularIVA()
        {
            Console.WriteLine("ingrese un numero para calcular iva :");
             int numero = Convert.ToInt32(Console.ReadLine());
            var calculo = numero * 1.21;
            Console.WriteLine("el precio sin iva es:" + numero);
            Console.WriteLine("el precio con iva es:" + calculo);
            Console.Read();
        }

        static void Main(string[] args)
        {
            CalcularIVA();
        }
    }
}
