using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9VAUM1007322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            // Calcula la sumatoria desde 1 hasta el número ingresado usando un do-while
            int sumatoria = 0;
            int contador = 1;
            do
            {
                sumatoria += contador;
                contador++;
            } while (contador <= numero);

            Console.WriteLine("Resultado de sumatoria " + sumatoria);
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("\nTabla del " + i + ":\t");

                for (int j = 1; j <= numero; j++)
                {
                    Console.Write(i * j + "\t");
                }
            }

            Console.ReadLine();
        }
    }
}
