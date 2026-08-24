using System;

namespace SistemaMatricula
{
    /// <summary>
    /// Clase principal del programa. 
    /// Aquí se encuentra el punto de entrada de la aplicación y donde crearemos los Objetos.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE MATRÍCULA TEC ===");
            
            // 1. Crear un Horario (Objeto)
            Horario horarioProgra = new Horario("Lunes", 8, 11, "A-301");
            
            // 2. Crear un Profesor (Demuestra Herencia)
            Profesor profe = new Profesor("Alan Turing", "1-1111-1111", 45, "Computación", 1500000.50);
            
            // 3. Crear un Curso (Relaciones entre objetos)
            Curso cursoProgra = new Curso("Programación Básica", 4, 30, profe, horarioProgra);
            
            // 4. Crear un Estudiante Regular (Herencia Nivel 2)
            Estudiante estudianteRegular = new Estudiante("Ada Lovelace", "2-2222-2222", 20, "2026123456", "Ing. Computadores");
            
            // 5. Crear un Estudiante Becado (Herencia Nivel 3)
            EstudianteBecado estudianteBecado = new EstudianteBecado("Grace Hopper", "3-3333-3333", 22, "2026654321", "Ing. Computadores", 50.0);
            
            // 6. DEMOSTRACIÓN DE POLIMORFISMO
            Console.WriteLine("\n--- Cobros de Matrícula (Polimorfismo) ---");
            Console.WriteLine($"{estudianteRegular.Nombre} paga: ₡{estudianteRegular.CalcularPagoMatricula(cursoProgra.Creditos)}");
            Console.WriteLine($"{estudianteBecado.Nombre} (Becada) paga: ₡{estudianteBecado.CalcularPagoMatricula(cursoProgra.Creditos)}");
            
            // 7. DEMOSTRACIÓN DE ENCAPSULAMIENTO
            Console.WriteLine("\n--- Proceso de Matrícula (Encapsulamiento) ---");
            Matricula sistema = new Matricula();
            // Usamos el método público para acceder a la lista privada
            sistema.Matricular(cursoProgra, estudianteRegular);
            sistema.Matricular(cursoProgra, estudianteBecado);
            
            // 8. DEMOSTRACIÓN DE ABSTRACCIÓN
            Console.WriteLine("\n--- Detalles en el Sistema ---");
            profe.MostrarDetalles();
            estudianteRegular.MostrarDetalles();
            estudianteBecado.MostrarDetalles();
        }
    }
}