using System;

namespace Flujo_de_datos___C2_Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe otro número ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("{0} es mayor que {1}", numero1, numero2);
            }
            else
            {
                if (numero1 < numero2)
                {
                    Console.WriteLine("{0} es mayor que {1}", numero2, numero1);
                }
                else
                {
                    Console.WriteLine("{0} es igual que {1}", numero1, numero2);
                }
            }
        }
    }
}
