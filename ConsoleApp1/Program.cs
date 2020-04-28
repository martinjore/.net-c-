using System;

namespace numeros1_100
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int numero = 0;
            while (numero < 100) {
                if (numero % 2==1)
                Console.WriteLine("numero:" + numero.ToString());
                numero++;
              }
            Console.ReadLine();
        }
    }
}
