using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller_estructurasDeControl
{
    internal class Biblioteca
    {

        private List<Libro> libros = new List<Libro>();

        public void AgregarLibro(Libro nuevoLibro)
        {
            libros.Add(nuevoLibro);
        }

        public void ListarLibros()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros en la biblioteca.");
                return;
            }

            foreach (var libro in libros)
            {
                libro.MostrarInfo();
                Console.WriteLine("----------------------");
            }
        }

        public void BuscarLibro(string titulo)
        {
            var encontrado = libros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (encontrado != null)
            {
                Console.WriteLine("Libro encontrado:");
                encontrado.MostrarInfo();
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }
    }
}
