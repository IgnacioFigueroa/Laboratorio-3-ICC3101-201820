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
            base.Informacion();
            Console.WriteLine("\tColor: {0}\n\tDescripcion:{1}", color, descripcion);
        }

    }
}
