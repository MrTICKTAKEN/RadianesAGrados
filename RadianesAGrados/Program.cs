using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadianesAGrados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Qué operación quieres te gustaria realizar?");
            Console.WriteLine("1. Grados a Radianes");
            Console.WriteLine("2. Radianes a Grados");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Ingresa los grados:");
                double grados = Convert.ToDouble(Console.ReadLine());
                double radianes = GradosARadianes(grados);
                Console.WriteLine($"{grados} grados es equivalente a {radianes} radianes.");
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Ingresa los radianes:");
                double radianes = Convert.ToDouble(Console.ReadLine());
                double grados = RadianesAGrados(radianes);
                Console.WriteLine($"{radianes} radianes es equivalente a {grados} grados.");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }

        static double GradosARadianes(double grados)
        {
            return grados * Math.PI / 180.0;
        }

        static double RadianesAGrados(double radianes)
        {
            return radianes * 180.0 / Math.PI;
        }
    }
}
