using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    class Marcador : Articulo
    {
        string color;
        string descripcion;

        public Marcador(string nombre, int stock, int precio, string color, string descripcion) : base(nombre, stock, precio)
        {
            this.color = color;
            this.descripcion = descripcion;
        }

        public override void Informacion()
        {
            Console.WriteLine("\t#{0}: {1}\n\tPrecio: {2}\n\tStock: {3}\n\tColor: {4}\n\tDescripcion:{5}", id, nombre, precio, stock, color, descripcion);
        }

    }
}
