using System;

namespace Console_19._10._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] a = new Alumno[3];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Alumno();
                Console.WriteLine("Nombre del alumno");
                a[i].Nombre = Console.ReadLine();
                Console.WriteLine("Numero de Matricula");
                a[i].Matricula = Console.ReadLine();
                Console.WriteLine("Nombre de la carrera");
                a[i].Carrera = Console.ReadLine();
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i].ToString());
            }
            {
                Console.ReadKey();
            }
        }
    }
}
