using Utilerias.TestingProgram;

Console.WriteLine("Hello, World!");

Utilities.ImprimirAlumno("Samuel", "Arellano");
Console.WriteLine("El sueldo de Samuel es: ");
Console.WriteLine(Utilities.CalcularSueldo(140.50));

Utilities.ImprimirAlumno("Carlos", "Mendoza");
Utilities.ImprimirAlumno("Enrique", "Valero");

Utilities.ImprimirAlumno(apellido: "Mendoza", nombre: "Jorge");

Utilities.ImprimirAlumno("Samuel", 42);

Utilities util = new Utilities();
Console.WriteLine(util.ToString());



// nombre = "Carlos";
// apellido = "Mendoza";

// Console.WriteLine(nombre + " " + apellido);

// nombre = "Enrique";
// apellido = "Valero";

// Console.WriteLine(nombre + " " + apellido);

// static void ImprimirAlumno(string nombre, string apellido)
// {
//     Console.WriteLine(nombre + " " + apellido);
// }

// static double CalcularSueldo(int horas, double sueldoPorHora)
// {
//     // var sueldo = horas * sueldoPorHora;
//     // return sueldo;
//     return horas * sueldoPorHora;
// }
