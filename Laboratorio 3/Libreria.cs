using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    class Libreria
    {
        Articulo[] articulos;

        public Libreria()
        {
            articulos = new Articulo[] { };
        }

        public void AgregarArticulo(Articulo articulo)
        {
            Array.Resize(ref articulos, articulos.Length + 1);
            articulos[articulos.Length - 1] = articulo;
        }

        public void VerArticulos()
        {
            foreach(Articulo art in articulos)
            {
                art.Resumen();
            }
        }

        public Articulo BuscarPorCodigo(int id)
        {
            foreach(Articulo art in articulos)
            {
                if (art.ObtenerId() == id)
                {
                    return art;
                }
            }
            return null;
        }
    }
}
