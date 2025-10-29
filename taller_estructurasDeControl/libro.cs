using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller_estructurasDeControl
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Publicacion { get; set; }
        public string Editorial { get; set; }

        public Libro(string titulo, string autor, int publicacion, string editorial)
        {
            Titulo = titulo;
            Autor = autor;
            Publicacion = publicacion;
            Editorial = editorial;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Año de Publicación: {Publicacion}");
            Console.WriteLine($"Editorial: {Editorial}");
        }


    }
}
