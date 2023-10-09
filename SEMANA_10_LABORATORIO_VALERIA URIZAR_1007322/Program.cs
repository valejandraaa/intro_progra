using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10VAUM1007322
{
    //clase Automovil
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Automovil automovil = new Automovil();

            Console.WriteLine("Modelo:" + automovil.modelo);
            Console.WriteLine("Precio:" + automovil.precio);
            Console.WriteLine("Marca:" + automovil.marca);
            Console.WriteLine("disponibilidad:" + automovil.disponibilidad);
            Console.WriteLine("tipocambiodolar:" + automovil.tipocambiodolar);
            Console.WriteLine("aplicardescuento:" + automovil.aplicardescuento);

            Console.ReadKey();

        }
    }

    //Creacion clase Automovil
    public class Automovil
    {
     public int modelo { get; set; } 
     public double precio { get; set; }
     public string marca { get; set; }
     public bool disponibilidad { get; set; }
     public double tipocambiodolar { get; set; }
     public  double aplicardescuento { get; set; }

     //constructor 

        public Automovil()
        {
            //definido datos por defecto
            this.modelo = 2019;
            this.precio = 1000.00;
            this.marca = "";
            this.disponibilidad = true;
            this.tipocambiodolar = 7.50;
            this.aplicardescuento = 0.00;

        }

     
        public.Automovil(int modelo, double precio, string marca, bool disponibilidad, double tipodecambio, double aplicardescuento)
        {
            this.modelo = modelo;
            this.precio = precio;
            this.marca = marca;
            this.disponibilidad = disponibilidad;
            this.tipocambiodolar = tipodecambio;
            this.aplicardescuento = aplicardescuento;

        }
               
            
    }
}
        

