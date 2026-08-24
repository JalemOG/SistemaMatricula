using System;

namespace src
{
    /// <summary>
    /// Representa a un docente dentro de la universidad. 
    /// Esta clase hereda de Persona, demostrando cómo reutilizar el código base 
    /// para crear un rol completamente distinto al del estudiante.
    /// </summary>
    public class Profesor : Persona
    {
        /// <summary>
        /// Área de conocimiento del profesor (ej. "Ingeniería en Computadores", "Matemática").
        /// </summary>
        public string Especialidad { get; set; }

        /// <summary>
        /// El salario base asignado al profesor. 
        /// Demuestra el uso del tipo de dato 'double' ideal para manejar dinero y decimales.
        /// </summary>
        public double SalarioBase { get; set; }

        /// <summary>
        /// Inicializa un nuevo objeto de tipo Profesor.
        /// </summary>
        /// <param name="nombre">Nombre completo del docente.</param>
        /// <param name="identificacion">Cédula o pasaporte del docente.</param>
        /// <param name="edad">Edad en años.</param>
        /// <param name="especialidad">El área académica en la que es experto.</param>
        /// <param name="salarioBase">Monto salarial de referencia.</param>
        public Profesor(string nombre, string identificacion, int edad, string especialidad, double salarioBase) 
            : base(nombre, identificacion, edad)
        {
            Especialidad = especialidad;
            SalarioBase = salarioBase;
        }

        /// <summary>
        /// Imprime en pantalla los datos específicos del profesor.
        /// Sobreescribe (override) el método abstracto definido en la clase Persona.
        /// </summary>
        public override void MostrarDetalles()
        {
            Console.WriteLine($"Profesor: {Nombre} | Especialidad: {Especialidad} | Salario Base: {SalarioBase}");
        }
    }
}