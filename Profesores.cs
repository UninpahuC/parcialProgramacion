using System;

namespace Programacion
{
    public class Profesores
    {
        public struct Person
        {
            public string Nombre;
            public string Cedula;
            public string Materia;
            public Person(string name, string cc, string materia)
            {
                Nombre = name;
                Cedula = cc;
                Materia = materia;
            }
        }

            public void crearProfesor()
            {
                string[] materias = {"español","matematicas", "etica"};
                for (int i = 0; i < 2; i++)
                {
                Console.WriteLine("Ingresa nombre cedula y materia (Profesor)");
                Person profesor = new Person(Console.ReadLine(), Console.ReadLine() , Console.ReadLine());
                Console.WriteLine("profesor Nombre = {0} Cedula = {1} materia = {2}", profesor.Nombre, profesor.Cedula, profesor.Materia);
                    if (profesor.Materia == materias[i])
                    {
                        Console.WriteLine(materias[i]);
                    } else {
                        Console.WriteLine("esta materia no esta registrada");
                    }
                }
        }
    }
}
