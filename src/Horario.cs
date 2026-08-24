using System;

namespace SistemaMatricula
{
    /// <summary>
    /// Representa el bloque de tiempo y espacio donde se imparte una clase.
    /// Es perfecta para explicar los Tipos de Datos.
    /// </summary>
    public class Horario
    {
        /// <summary>
        /// El día de la semana (ej. "Lunes"). 
        /// Demuestra el uso del tipo de dato 'string' para cadenas de texto.
        /// </summary>
        public string DiaSemana { get; set; }

        /// <summary>
        /// La hora de inicio (formato 24h). 
        /// Demuestra el uso del tipo de dato 'int' para números enteros.
        /// </summary>
        public int HoraInicio { get; set; }

        /// <summary>
        /// La hora de finalización (formato 24h).
        /// </summary>
        public int HoraFin { get; set; }

        /// <summary>
        /// El aula física asignada.
        /// </summary>
        public string Aula { get; set; }

        /// <summary>
        /// Constructor: Construye el evento en el calendario.
        /// </summary>
        public Horario(string diaSemana, int horaInicio, int horaFin, string aula)
        {
            DiaSemana = diaSemana;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            Aula = aula;
        }

        /// <summary>
        /// Une todos los datos para devolver un texto legible.
        /// Demuestra que las funciones también tienen Tipos de Datos (en este caso, retorna un 'string').
        /// </summary>
        /// <returns>Una cadena de texto con el formato del horario.</returns>
        public string ObtenerFormatoHorario()
        {
            return $"{DiaSemana} de {HoraInicio}:00 a {HoraFin}:00 en el aula {Aula}";
        }
    }
}