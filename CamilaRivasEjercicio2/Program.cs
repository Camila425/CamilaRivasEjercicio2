using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamilaRivasEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
			double LadoA, LadoB, LadoC ;


			Console.Write( "Ingrese la primer medida del triangulo:");
			LadoA=Convert.ToDouble(Console.ReadLine());
			Console.Write("Ingrese la segunda medida del triangulo:");
			LadoB=Convert.ToDouble(Console.ReadLine());
			Console.Write( "Ingrese la tercer medida del triangulo:");
			LadoC=Convert.ToDouble(Console.ReadLine());
            if (LadoA + LadoB > LadoC && LadoB+LadoC > LadoA && LadoA+LadoC >LadoB)
            {
                if (LadoA == LadoB && LadoA == LadoC)
                {
					Console.WriteLine("Los lados ingresados conforman un triangulo:Equilatero");
                }
                else
                {
                    if (LadoA == LadoB || LadoA == LadoC || LadoC == LadoB)
                    {
                        Console.WriteLine("Los lados ingresados conforman un triangulo:Isosceles");
                    }
                    else
                    {
                        Console.WriteLine("Los lados ingresados conforman un triangulo:Escaleno");
                    }
                }
                

            }
            else
            {
                Console.WriteLine("los lados ingresados no conforman un triangulo");
            }
            Console.ReadLine();
			
		

		}
    }
}
