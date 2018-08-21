using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    class Libro : Articulo
    {
        string editorial;
        int paginas;
        string autor;

        public Libro(string nombre, int stock, int precio, string editorial, int paginas, string autor) : base(nombre, stock, precio)
        {
            this.editorial = editorial;
            this.paginas = paginas;
            this.autor = autor;
        }

        public override void Informacion()
        {
            Console.WriteLine("#{0}: {1}\n\tPrecio: {2}\n\tStock: {3}\n\tEditorial: {4}\n\tPaginas: {5}\n\tAutor: {6}", id, nombre, precio, stock, editorial, paginas, autor);

        }
    }
}
