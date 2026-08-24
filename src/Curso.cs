using System;

namespace SistemaMatricula
{
    /// <summary>
    /// Representa la materia académica. 
    /// Une diferentes clases (Profesor y Horario) dentro de una sola estructura.
    /// </summary>
    public class Curso
    {
        public string NombreCurso { get; set; }
        public int Creditos { get; set; }
        public int CupoMaximo { get; set; }

        /// <summary>
        /// El docente asignado al curso.
        /// Demuestra cómo un Objeto puede estar compuesto por otros Objetos.
        /// </summary>
        public Profesor ProfesorAsignado { get; set; }

        /// <summary>
        /// El bloque de tiempo del curso.
        /// </summary>
        public Horario HorarioCurso { get; set; }

        public Curso(string nombreCurso, int creditos, int cupoMaximo, Profesor profesorAsignado, Horario horarioCurso)
        {
            NombreCurso = nombreCurso;
            Creditos = creditos;
            CupoMaximo = cupoMaximo;
            ProfesorAsignado = profesorAsignado;
            HorarioCurso = horarioCurso;
        }

        /// <summary>
        /// Verifica si aún hay espacios en el curso.
        /// CONCEPTO: Método (Una acción que el objeto puede realizar).
        /// </summary>
        /// <param name="cantidadMatriculados">Número actual de estudiantes inscritos.</param>
        /// <returns>Verdadero si hay campo, Falso si está lleno.</returns>
        public bool HayCupo(int cantidadMatriculados)
        {
            return cantidadMatriculados < CupoMaximo;
        }
    }
}