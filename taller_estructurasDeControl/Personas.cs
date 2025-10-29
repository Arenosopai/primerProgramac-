using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller_estructurasDeControl
{
       public class personas
        {
            public string nombre { get; set; }
            public int edad { get; set; }
            public char Genero { get; set; } // F o M
            public string Telefono { get; set; }

        public personas(string nombre, int edad, char genero, string telefono)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.Genero = genero;
            this.Telefono = telefono;
        }
        public void ImprimirDetalles()
        {
            Console.WriteLine("----- Detalles de la Persona -----");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Género: {Genero}");
            Console.WriteLine($"Teléfono: {Telefono}");
        }

        // Método para calcular edad en días
        public void CalcularEdadEnDias()
        {
            int edadEnDias = edad * 365;
            Console.WriteLine($"Edad en días: {edadEnDias}");
        }

        // Método para editar información
        public void EditarInformacion(string nuevoNombre, int nuevaEdad, char nuevoGenero, string nuevoTelefono)
        {
            nombre = nuevoNombre;
            edad = nuevaEdad;
            Genero = nuevoGenero;
            Telefono = nuevoTelefono;
            Console.WriteLine("Información actualizada correctamente.");
        }
    }







}












   

