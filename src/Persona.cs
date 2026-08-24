using System;

namespace src
{
    /// <summary>
    /// Abstracción y Clase.
    /// Es el "molde genérico" para cualquier individuo en la universidad.
    /// Al ser 'abstract', el sistema no permite crear objetos directos de ella 
    /// (nadie es "solo una persona" en el sistema, debe tener un rol).
    /// </summary>
    public abstract class Persona
    {
        /// <summary>
        /// Nombre completo del individuo. 
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Documento de identidad.
        /// </summary>
        public string Identificacion { get; set; }

        /// <summary>
        /// Edad en años. 
        /// Demuestra el tipo de dato 'int' para números enteros                                                                                                        
        /// </summary>
        public int Edad { get; set; }

        /// <summary>
        /// Constructor que inicializa los datos básicos que toda persona debe tener.
        /// </summary>
        /// <param name="nombre">Nombre completo.</param>
        /// <param name="identificacion">Cédula o pasaporte.</param>
        /// <param name="edad">Edad actual.</param>
        public Persona(string nombre, string identificacion, int edad)
        {
            Nombre = nombre;
            Identificacion = identificacion;
            Edad = edad;
        }

        /// <summary>
        /// Método abstracto que obliga a las clases hijas
        /// a definir cómo mostrar sus propios detalles. 
        /// </summary>
        public abstract void MostrarDetalles();
    }
}