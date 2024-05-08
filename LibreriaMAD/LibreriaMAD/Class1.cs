﻿using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LibreriaMAD
{
    public class Folio
    {
        private static int lastFolio = 0;

        public int Numero { get;  }

        public Folio()
        {
            Numero = ++lastFolio;
        }
    }

    public class Persona
    { 
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int  Edad {  get; set; }

        public Persona (string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }
    }

    public class Carrera
    {
        public string Nombre { get; set; }

        public Carrera (string nombre)
        {
            Nombre = nombre;
        }
    }

    public class Asignatura
    { 
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public Asignatura (string nombre, string codigo)
        {
            Nombre = nombre;
            Codigo = codigo;
        }
    }

    public class Grupo
    { 
        public string Nombre { get; set; }
        
        public Grupo(string nombre)
        { 
            Nombre = nombre; 
        }
    }

    public class Docente
    { 
        public string Nombre { get; set; }
        public Docente(string nombre)
        {
            Nombre = nombre;
        }
    }

    public class Incidencia
    { 
        public string Descripcion { get; set; }
        public Incidencia(string descripcion)
        {
            Descripcion = descripcion;
        }
    }

    public class Aula
    { 
        public string Nombre { get; set; }
        public Aula(string nombre)
        {
            Nombre = nombre;
        }
    }

    public class RegistroIncidencia
    { 
        public Folio Folio { get; }
        public DateTime Fecha { get; }
        public Persona Persona { get; }
        public Carrera Carrera { get; }
        public Asignatura Asignatura { get; }
        public Grupo Grupo { get; }
        public Docente Docente { get; }
        public Incidencia Incidencia { get; }
        public Aula Aula { get; }

        public RegistroIncidencia(Persona persona, Carrera carrera, Asignatura asignatura, Grupo grupo, Docente docente, Incidencia incidencia, Aula aula)
        {
            Folio = new Folio();
            Fecha = DateTime.Now;
            Persona = persona;
            Carrera = carrera;
            Asignatura = asignatura;
            Grupo = grupo;
            Docente = docente;
            Incidencia = incidencia;
            Aula = aula;
        }
    }

    public class Visualizador
    {
        public static void MostrarAulasDisponibles(List<Aula> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine($"Aula: {aula.Nombre}");
                // Aquí podrías mostrar más detalles sobre el aula si lo deseas
            }
        }

        public static void MostrarRegistroIncidencia(RegistroIncidencia registro)
        {
            Console.WriteLine($"Folio: {registro.Folio.Numero}");
            Console.WriteLine($"Fecha: {registro.Fecha}");
            Console.WriteLine($"Nombre: {registro.Persona.Nombre}");
            Console.WriteLine($"Apellido: {registro.Persona.Apellido}");
            Console.WriteLine($"Carrera: {registro.Carrera}");
            Console.WriteLine($"Grupo: {registro.Grupo}");
            Console.WriteLine($"Aula: {registro.Aula}");
            Console.WriteLine($"Incidencia: {registro.Incidencia}");

            // Mostrar más detalles del registro según sea necesario
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los datos del alumno:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Persona persona = new Persona(nombre, apellido, edad);

            Console.WriteLine("\nIngrese los datos de la carrera:");
            Console.Write("Nombre de la carrera: ");
            string nombreCarrera = Console.ReadLine();

            Carrera carrera = new Carrera(nombreCarrera);

            Console.WriteLine("\nIngrese los datos de la asignatura:");
            Console.Write("Nombre de la asignatura: ");
            string nombreAsignatura = Console.ReadLine();
            Console.Write("Código de la asignatura: ");
            string codigoAsignatura = Console.ReadLine();

            Asignatura asignatura = new Asignatura(nombreAsignatura, codigoAsignatura);

            Console.WriteLine("\nIngrese los datos del grupo:");
            Console.Write("Nombre del grupo: ");
            string nombreGrupo = Console.ReadLine();

            Grupo grupo = new Grupo(nombreGrupo);

            Console.WriteLine("\nIngrese los datos del docente:");
            Console.Write("Nombre del docente: ");
            string nombreDocente = Console.ReadLine();

            Docente docente = new Docente(nombreDocente);

            Console.WriteLine("\nIngrese los datos de la incidencia:");
            Console.Write("Descripción de la incidencia: ");
            string descripcionIncidencia = Console.ReadLine();

            Incidencia incidencia = new Incidencia(descripcionIncidencia);

            Console.WriteLine("\nIngrese los datos del aula:");
            Console.Write("Nombre del aula: ");
            string nombreAula = Console.ReadLine();

            Aula aula = new Aula(nombreAula);

            RegistroIncidencia registro = new RegistroIncidencia(persona, carrera, asignatura, grupo, docente, incidencia, aula);

            Console.WriteLine("\nRegistro de Incidencia:");
            Visualizador.MostrarRegistroIncidencia(registro);
        }
    }

}