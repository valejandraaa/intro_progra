using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12VAUM1007322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo objCirculo;

            Console.WriteLine("Ingrese el radio del círculo: ");
            double r = Convert.ToDouble(Console.ReadLine());
            objCirculo = new Circulo(r);

            double perimetro = 0;
            double area = 0;
            double volumen = 0;

            objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);

            Console.WriteLine("Perímetro del círculo: " + perimetro + "cm");
            Console.WriteLine("Área del círculo: " + area + "cm^2");
            Console.WriteLine("Volumen del círculo: " + volumen + "cm^3");
        }


 
        public class Circulo
        {
            //atributos

            private double radio { get; set; }

            public Circulo(double r)
            {
                //definiendo datos por defecto
                this.radio = r;
            }

            //función perímetro
            private double ObtenerPerimetro(double r)
            {
                return 2 * Math.PI * r;
            }

            //función área
            private double ObtenerArea(double r)
            {
                return Math.PI * Math.Pow(r, 2);
            }

            //función volumen
            private double ObtenerVolumen(double r)
            {
                return (4 * Math.PI * Math.Pow(r, 3) / 3);
            }

            //procedimiento para Calcular Geometría
            public void CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
            {
                unPerimetro = ObtenerPerimetro(radio);

                unArea = ObtenerArea(radio);

                unVolumen = ObtenerVolumen(radio);
            }
        }
    }
}
