using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l14VAUM1007322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[7];
            int numeroMayor = int.MinValue;
            int numeroMenor = int.MaxValue;
            int cantidadNegativos = 0;
            int cantidadPositivos = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if (numeros[i] > numeroMayor)
                {
                    numeroMayor = numeros[i];
                }
                else if (numeros[i] < numeroMenor)
                {
                    numeroMenor = numeros[i];
                }

                if (numeros[i] < 0)
                {
                    cantidadNegativos++;
                }
                else if (numeros[i] > 0)
                {
                    cantidadPositivos++;
                }
            }

            Console.WriteLine("El número mayor es: {numeroMayor}");
            Console.WriteLine("El número menor es: {numeroMenor}");
            Console.WriteLine("La cantidad de números negativos es: {cantidadNegativos}");
            Console.WriteLine("La cantidad de números positivos es: {cantidadPositivos}");

            Console.WriteLine("Los números ingresados son: ");
            foreach (int numero in numeros)
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine();

            Console.Write("¿Desea ingresar otro número? (s/n): ");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "s")
            {
                Console.WriteLine("Ingrese un número adicional: ");
                int numeroAdicional = Convert.ToInt32(Console.ReadLine());



















            }
        
    }
}
