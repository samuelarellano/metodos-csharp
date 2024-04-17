using System.Runtime.CompilerServices;

namespace Utilerias.TestingProgram
{
    /// <summary>
    /// Clase de Utilierías para Testing Program
    /// </summary>
    internal class Utilities
    {
        #region ImprimirAlumno
        
        /// <summary>
        /// Funcion para Imprimir Nombre del Alumno
        /// </summary>
        /// <param name="nombre">recibe nombre</param>
        /// <param name="apellido">recibe apellido</param>
        public static void ImprimirAlumno(string nombre, string apellido)
        {
            Console.WriteLine(nombre + " " + apellido);
        }

        public static void ImprimirAlumno(string nombre) => Console.WriteLine(nombre);

        public static void ImprimirAlumno(string nombre, int edad) => Console.WriteLine(nombre + " " + edad);

        public static string ImprimirAlumno(string nombre, string apellido, int edad) => nombre + " " + apellido + " " + edad;

        // public static double CalcularSueldo(double sueldoPorHora, int horas = 40)
        // {
        //     // var sueldo = horas * sueldoPorHora;
        //     // return sueldo;
        //     return horas * sueldoPorHora;
        // }


        #endregion
        public static double CalcularSueldo(double sueldoPorHora, int horas = 40) => horas * sueldoPorHora;

        public override string ToString()
        {
            return ImprimirAlumno("Samuel", "Arellano", 42);
        }

    }
}
