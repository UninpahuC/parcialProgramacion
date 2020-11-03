using System;

namespace Programacion
{
    public class Administrativos
    {
        public struct Person
        {
            public string Nombre;
            public string Cedula;
            public string Area;
            public Person(string name, string cc, string area)
            {
                Nombre = name;
                Cedula = cc;
                Area = area;
            }
        }

            public void crearAdministrativo()
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Ingresa nombre cedula y area (Administrativos)");
                Person Administrativo = new Person(
                    Console.ReadLine(),
                    Console.ReadLine(),
                    Console.ReadLine());
                    Console.WriteLine("Administrativo Nombre = {0} Cedula = {1} area = {2}",
                    Administrativo.Nombre,
                    Administrativo.Cedula,
                    Administrativo.Area);
                }
        }
    }
}
