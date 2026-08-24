using System;
using System.Collections.Generic;

namespace SistemaMatricula
{
    /// <summary>
    /// Gestiona el proceso de inscripción de los estudiantes a los cursos.
    /// Es la clase ideal para explicar el concepto de ENCAPSULAMIENTO.
    /// </summary>
    public class Matricula
    {
        /// <summary>
        /// ATRIBUTO PRIVADO (Encapsulamiento): 
        /// Al ser 'private', ninguna otra clase puede agregar o borrar cursos de esta lista 
        /// a la fuerza. Solo la propia clase Matricula tiene el control de su información.
        /// </summary>
        private List<Curso> cursosMatriculados;

        /// <summary>
        /// Constructor que inicializa la lista vacía para que esté lista para usarse.
        /// </summary>
        public Matricula()
        {
            cursosMatriculados = new List<Curso>();
        }

        /// <summary>
        /// MÉTODO PÚBLICO:
        /// Es la única "puerta de entrada" permitida para modificar la lista privada. 
        /// Antes de agregar un curso, verifica las reglas del negocio (ej. si hay cupo).
        /// </summary>
        /// <param name="nuevoCurso">El curso que el estudiante desea matricular.</param>
        /// <param name="estudiante">El estudiante que está haciendo el trámite.</param>
        public void Matricular(Curso nuevoCurso, Estudiante estudiante)
        {
            // Validamos a través del método de la clase Curso si hay espacio
            if (nuevoCurso.HayCupo(cursosMatriculados.Count))
            {
                // Si todo está en orden, guardamos el curso en la lista privada
                cursosMatriculados.Add(nuevoCurso);
                Console.WriteLine($"¡Éxito! El estudiante {estudiante.Nombre} ha matriculado {nuevoCurso.NombreCurso}.");
            }
            else
            {
                Console.WriteLine($"Error: El curso {nuevoCurso.NombreCurso} ya no tiene cupo disponible.");
            }
        }
    }
}