using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        public static void ClasesAsistencias(int cursadas, int asistencias)
        {
            if (((asistencias * 100) / cursadas) > 80)
            {
                Console.WriteLine("Aprobaste la cursada");         
            }
            else
            { 
                Console.WriteLine("No aprobaste la cursada");
            }
        
        }

        static void Main(string[] args)
        {
            string nombre;
            int diasCursadas, asistencias;
            Console.WriteLine("Ingresar Nombre completo: ");
            nombre = Console.ReadLine();

            Console.WriteLine("cantidad de dias de la cursada: ");
            diasCursadas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dias de asistencias: ");
            asistencias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nombre);
            Console.WriteLine("");
            ClasesAsistencias(diasCursadas, asistencias);
        }
    }
}
