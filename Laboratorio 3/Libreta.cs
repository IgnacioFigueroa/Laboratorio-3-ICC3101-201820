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
            base.Informacion();
            Console.Write("\tColor: {0}\n\tHojas:{1}\n\tTapaDura: {2}\n", color, hojas, tapaDura);

        }
    }
}
