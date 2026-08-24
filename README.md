# Sistema de Matrícula - Demostración de Programación Orientada a Objetos en C#

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![DocFX](https://img.shields.io/badge/DocFX-Documentation-008080?style=for-the-badge)
![Build](https://img.shields.io/badge/Build-Passing-brightgreen?style=for-the-badge)

**Instituto Tecnológico de Costa Rica (TEC)**
**Escuela de Ingeniería en Computadores**
**Curso:** Algoritmos y Estructuras de Datos I (CE 1103)
**Periodo:** II Semestre 2026

---

## Descripción del Proyecto

Este repositorio contiene una aplicación de consola desarrollada en el lenguaje C#, diseñada con el propósito fundamental de servir como material educativo para la demostración práctica de los paradigmas de la Programación Orientada a Objetos (POO). El sistema simula la lógica de negocio subyacente de un proceso de matrícula universitario.

El proyecto ha sido desarrollado como cumplimiento de los entregables técnicos de la Tarea Extraclase #1 del curso[cite: 1]. Su diseño se enfoca en la correcta implementación arquitectónica y en la comunicación efectiva de conceptos de ingeniería de software para un público meta con conocimientos básicos de programación[cite: 1].

## Conceptos de POO Implementados

El sistema fue estructurado metódicamente para ejemplificar de manera explícita los siguientes ocho conceptos fundamentales en una misma aplicación[cite: 1]:

1. **Clase:** Definición de plantillas y modelos teóricos (ej. `Curso`, `Horario`)[cite: 1].
2. **Método:** Comportamientos y rutinas asignadas a las clases (ej. validaciones de cupo)[cite: 1].
3. **Objeto:** Instanciación física en memoria durante el tiempo de ejecución[cite: 1].
4. **Encapsulamiento:** Protección de estructuras de datos sensibles y control de acceso[cite: 1].
5. **Herencia:** Implementación jerárquica de clases para la reutilización de código[cite: 1].
6. **Polimorfismo:** Modificación de comportamientos heredados para el cálculo dinámico de aranceles[cite: 1].
7. **Abstracción:** Uso de clases base abstractas para definir contratos y atributos comunes[cite: 1].
8. **Tipos de Datos:** Uso riguroso de tipos primitivos (enteros, cadenas) y objetos complejos tanto en atributos como en el retorno de funciones[cite: 1].

## Arquitectura y Requisitos Técnicos

El proyecto cumple con los requisitos técnicos establecidos en la especificación, estructurándose de la siguiente manera:

* **Jerarquía de Personas (Demostración de Herencia Nivel 3)[cite: 1]:**
  * `Persona.cs`: Clase base abstracta de primer nivel.
  * `Estudiante.cs`: Hereda de la clase `Persona` (Nivel 2).
  * `EstudianteBecado.cs`: Hereda de la clase `Estudiante` (Nivel 3).
  * `Profesor.cs`: Hereda de la clase `Persona` (Nivel 2).
* **Componentes Funcionales del Sistema (Supera el mínimo de 6 clases distintas)[cite: 1]:**
  * `Horario.cs`: Gestión de bloques temporales y demostración del uso de tipos de datos.
  * `Curso.cs`: Composición de objetos y métodos de validación de negocio.
  * `Matricula.cs`: Gestión del proceso de inscripción y demostración de encapsulamiento estricto.
  * `Program.cs`: Punto de entrada principal de la aplicación (`Main`).

## Instrucciones de Ejecución

Para compilar y ejecutar este proyecto localmente, es indispensable contar con el SDK de **.NET 8.0** instalado en el entorno de desarrollo.

1. Clonar el repositorio en el sistema de archivos local.
2. Abrir una interfaz de línea de comandos (terminal) y navegar al directorio raíz del proyecto.
3. Ejecutar el comando de restauración de dependencias y construcción:
   ```bash
   dotnet restore
   dotnet build
