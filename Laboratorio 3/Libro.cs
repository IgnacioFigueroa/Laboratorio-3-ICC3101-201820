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
            base.Informacion();
            Console.WriteLine("\tEditorial: {0}\n\tPaginas: {1}\n\tAutor: {2}", editorial, paginas, autor);

        }
    }
}
