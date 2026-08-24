using System;

namespace SistemaMatricula
{
    /// <summary>
    /// Representa a un estudiante regular de la universidad.
    /// Demuestra el concepto de Herencia, ya que obtiene automáticamente el Nombre, 
    /// Identificación y Edad de la clase base Persona.
    /// </summary>
    public class Estudiante : Persona
    {
        /// <summary>
        /// Identificador único universitario del estudiante.
        /// </summary>
        public string Carne { get; set; }

        /// <summary>
        /// Nombre de la carrera que está cursando actualmente.
        /// </summary>
        public string Carrera { get; set; }

        /// <summary>
        /// Inicializa un nuevo estudiante. Note cómo usa 'base(...)' para enviar 
        /// los datos genéricos a la clase padre (Persona) para que ella los maneje.
        /// </summary>
        /// <param name="nombre">Nombre completo.</param>
        /// <param name="identificacion">Cédula o pasaporte.</param>
        /// <param name="edad">Edad en años.</param>
        /// <param name="carne">El carné universitario.</param>
        /// <param name="carrera">La carrera matriculada.</param>
        public Estudiante(string nombre, string identificacion, int edad, string carne, string carrera) 
            : base(nombre, identificacion, edad)
        {
            Carne = carne;
            Carrera = carrera;
        }

        /// <summary>
        /// Imprime en pantalla los datos específicos del estudiante.
        /// Sobreescribe (override) la acción obligatoria definida en Persona.
        /// </summary>
        public override void MostrarDetalles()
        {
            Console.WriteLine($"Estudiante: {Nombre} | Carné: {Carne} | Carrera: {Carrera}");
        }

        /// <summary>
        /// Calcula el costo total de los cursos a matricular.
        /// Este método es 'virtual' para permitir que clases hijas (como EstudianteBecado) 
        /// lo modifiquen, abriendo paso al concepto de Polimorfismo.
        /// </summary>
        /// <param name="creditos">Cantidad total de créditos a llevar en el semestre.</param>
        /// <returns>Costo base de la matrícula.</returns>
        public virtual double CalcularPagoMatricula(int creditos)
        {
            double precioPorCredito = 23180.0;
            return creditos * precioPorCredito;
        }
    }
}