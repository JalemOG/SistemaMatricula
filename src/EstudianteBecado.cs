using System;

namespace src
{
    /// <summary>
    /// Representa a un estudiante que cuenta con un porcentaje de descuento en su matrícula.
    /// 
    /// CONCEPTOS APLICADOS:
    /// 1. Herencia Nivel 3: Esta clase hereda de Estudiante, la cual a su vez hereda de Persona 
    ///    (Persona -> Estudiante -> EstudianteBecado).
    /// 2. Polimorfismo: Modifica la forma en la que se calcula el pago de la matrícula, 
    ///    aplicando un descuento específico que un estudiante regular no tiene.
    /// </summary>
    public class EstudianteBecado : Estudiante
    {
        /// <summary>
        /// Porcentaje de descuento aplicado a la matrícula (por ejemplo, 50 para un 50% de beca).
        /// </summary>
        public double PorcentajeBeca { get; set; }

        /// <summary>
        /// Inicializa un nuevo estudiante becado. Note cómo usa 'base(...)' para enviar 
        /// los datos generales a la clase Estudiante, añadiendo únicamente el porcentaje de beca.
        /// </summary>
        /// <param name="nombre">Nombre completo del estudiante.</param>
        /// <param name="identificacion">Cédula o pasaporte.</param>
        /// <param name="edad">Edad en años.</param>
        /// <param name="carne">Identificador único universitario.</param>
        /// <param name="carrera">Carrera que cursa actualmente.</param>
        /// <param name="porcentajeBeca">El porcentaje de descuento que posee.</param>
        public EstudianteBecado(string nombre, string identificacion, int edad, string carne, string carrera, double porcentajeBeca) 
            : base(nombre, identificacion, edad, carne, carrera)
        {
            PorcentajeBeca = porcentajeBeca;
        }

        /// <summary>
        /// Calcula el costo total de la matrícula aplicando el descuento de la beca.
        /// Sobreescribe (override) el comportamiento original definido en la clase Estudiante.
        /// </summary>
        /// <param name="creditos">Cantidad de créditos a matricular.</param>
        /// <returns>El costo final a pagar con el descuento ya aplicado.</returns>
        public override double CalcularPagoMatricula(int creditos)
        {
            // Primero, calculamos cuánto costaría normalmente (reutilizando el código del padre)
            double costoBase = base.CalcularPagoMatricula(creditos);
            
            // Luego, calculamos cuánto dinero representa el porcentaje de descuento
            double descuento = costoBase * (PorcentajeBeca / 100);
            
            // Finalmente, retornamos el precio con el descuento aplicado
            return costoBase - descuento;
        }
    }
}