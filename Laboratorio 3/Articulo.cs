using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    abstract class Articulo
    {
        protected int id;
        protected string nombre;
        protected int stock;
        protected int precio;
        static int ids = 0;

        public Articulo(string nombre, int stock, int precio)
        {
            id = ObtenerNuevoID();
            this.nombre = nombre;
            this.stock = stock;
            this.precio = precio;

        }

        public int ObtenerId()
        {
            return id;
        }

        public virtual void Informacion()
        {
            Console.WriteLine("#{0}: {1}\n\tPrecio:{2}\n\tStock:{3}", id, nombre, precio, stock);
        }

        public void Resumen()
        {
            Console.WriteLine("#{0}: {1}", id, nombre);
        }

        public bool TieneStock()
        {
            if (stock>0)
            {
                return true;
            }
            return false;
        }

        public bool Comprar()
        {
            if (stock > 0)
            {
                stock--;
                return true;
            }
            return false;
        }

        static int ObtenerNuevoID()
        {
            ids++;
            return ids - 1;
        }

    }
}
