using System;

namespace Programacion
{
    public class Estudiantes
    {
        public struct Person
        {
            public string Nombre;
            public string Cedula;
            public string Horario;
            public Person(string name, string cc, string horario)
            {
                Nombre = name;
                Cedula = cc;
                Horario = horario;
            }
        }

                public string cadaEstudiante;
            public string crearEstudiante()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Ingresa nombre cedula y materia (Estudiante)");
                Person estudiante = new Person(
                    Console.ReadLine(),
                    Console.ReadLine(),
                    Console.ReadLine());
                Console.WriteLine("estudiante Nombre = {0} Cedula = {1} horario = {2}",
                    estudiante.Nombre,
                    estudiante.Cedula,
                    estudiante.Horario);
                    cadaEstudiante = estudiante.Nombre + estudiante.Cedula + estudiante.Horario;
                }
                Console.WriteLine(cadaEstudiante + "este es el return");
            return cadaEstudiante;
        }
    }
}
