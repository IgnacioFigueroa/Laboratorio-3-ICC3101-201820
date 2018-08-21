using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    class Libreta : Articulo
    {
        string color;
        string hojas;
        bool tapaDura;

        public Libreta(string nombre, int stock, int precio, string color, string hojas, bool tapaDura) : base(nombre, stock, precio)
        {
            this.color = color;
            this.hojas = hojas;
            this.tapaDura = tapaDura;
        }

        public override void Informacion()
        {
            Console.WriteLine("#{0}: {1}\n\tPrecio: {2}\n\tStock: {3}\n\tColor: {4}\n\tHojas:{5}\n\tTapaDura: {6}", id, nombre, precio, stock, color, hojas, tapaDura);

        }
    }
}
