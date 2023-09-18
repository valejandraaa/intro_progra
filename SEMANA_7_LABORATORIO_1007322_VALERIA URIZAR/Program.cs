using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace L7VAUM1007322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");
            string numero1 = Console.ReadLine();
            int num1 = Convert.ToInt32(numero1);

            Console.WriteLine("Ingrese otro numero:");
            string numero2 = Console.ReadLine();
            int num2 = Convert.ToInt32(numero2);

            Console.WriteLine("Ingrese otro numero:");
            string numero3= Console.ReadLine();
            int num3 = Convert.ToInt32(numero3); 


            //suma 
            int suma = num1 + num2;
            Console.WriteLine("suma: " + num1 + " + " + num2 + " = " + suma);
            Console.ReadKey();

            //resta
            int resta = num1 + num2;
            Console.WriteLine("resta: " + num1 + " + " + num2 + " = " + resta);
            Console.ReadKey();

            //multiplicacion
            int multiplicacion = num1 + num2;
            Console.WriteLine("multiplicacion:" + num1 + " + " + num2 + " = " + multiplicacion);
            Console.ReadKey();

            //division
            int division = num1 + num2;
            Console.WriteLine("division: " + num1 + " + " + num2 + " = " + division);
            Console.ReadKey();

            Console.WriteLine("Ejercicio 2");  
                if (num1 > num2) ;
            {
                Console.WriteLine(num1 + " es mayor que: " + num2); 
            }


            Console.WriteLine("Ejercicio numero 3");

            // Jerarquia de operaciones 
            int operacion1 = (num1 * num2) + num3; 
            Console.WriteLine("resultado de la operacion 1:" + num1 + " * " + num2 + " + " + num3 + " = " + operacion1);
            Console.ReadKey();
            int operacion2 = num1 / (num2 * num3);
            Console.WriteLine("resultado de la operacion 2:" + num1 + " / " + num2 + " * " + num3 + " = " + operacion2);
            Console.ReadKey();
        }













    }
    }
