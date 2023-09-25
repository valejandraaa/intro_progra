using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8VAUM1007322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("laboratorio semana 8");
            Console.WriteLine("\nIngrese un numero");

            int N = Convert.ToInt32(Console.ReadLine());

            int A = 0, B = 1, C = 0, I = 2;
            String resultado = "";


            if (N > 0)
            {
                resultado = A.ToString();
                if (N > 1)
                {
                    resultado =  B.ToString();
                    while (I < N)
                    {
                        C = A + B;
                        resultado += C.ToString();
                        A = B;
                        B = C;
                        I++; 
                    

                    }
                    Console.WriteLine("Resultado" + resultado);
                     
                }
                else
                {
                    Console.WriteLine("Resultado " + resultado);

                }
               
                    
           
                   
            } 
            else
            {
                Console.WriteLine("Resultado " + resultado);

            }
                


            
            









        }
    }
}
