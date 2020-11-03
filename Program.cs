using System;

namespace Programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesores profesor = new Profesores();
            profesor.crearProfesor();
            Administrativos Administrativo = new Administrativos();
            Administrativo.crearAdministrativo();
            Estudiantes Estudiante = new Estudiantes();
            Estudiante.crearEstudiante();
            Console.WriteLine(Estudiante.cadaEstudiante + "desde program");
        }
        
    }
}
