using System;

namespace procedimiento
{
    class Program
    {
        public static void CalcularIVA()
        {
            Console.WriteLine("ingrese un numero para calcular iva :");
       
            int numero = Convert.ToInt32(Console.ReadLine());
            var calculo = numero * iva();
           
            Console.WriteLine("el precio sin iva es:" + numero);
            Console.WriteLine("el precio con iva es:" + calculo);
            Console.Read();
        }
        public static Double iva()
        {
            return 1.21;
        }
        
        static void Main(string[] args)
        {
            CalcularIVA();
        }
    }
}
