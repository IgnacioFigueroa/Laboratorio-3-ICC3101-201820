using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    static class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Libreria libreria = new Libreria();
            #region
            libreria.AgregarArticulo(new Marcador("Marcador Maped clasico", 5, 990, "Amarillo", "Marca lo importante"));
            libreria.AgregarArticulo(new Marcador("Marcador Maped clasico", 10, 990, "Verde", "Marca lo importante"));
            libreria.AgregarArticulo(new Marcador("Marcador Maped clasico", 30, 990, "Morado", "Marca lo importante"));
            libreria.AgregarArticulo(new Marcador("Marcador Maped clasico", 24, 990, "Rosado", "Marca lo importante"));
            libreria.AgregarArticulo(new Marcador("Marcador Maped clasico", 13, 990, "Naranjo", "Marca lo importante"));
            libreria.AgregarArticulo(new Libreta("Libreta HelloKitty", 10, 5990, "Rosado", "100", true));
            libreria.AgregarArticulo(new Libreta("Libreta IronMan", 10, 5990, "Rojo", "100", true));
            libreria.AgregarArticulo(new Libreta("Libreta ejecutiva", 10, 3990, "Negro", "120", true));
            libreria.AgregarArticulo(new Libreta("Libreta pequeña", 10, 2090, "Rosado", "100", true));
            libreria.AgregarArticulo(new Libreta("Libreta HelloKitty", 10, 5990, "Rosado", "100", true));
            libreria.AgregarArticulo(new Libro("Object Oriented Programming for dummies", 37, 5000, "DPM", 120, "Sebastian Baixas"));
            libreria.AgregarArticulo(new Libro("Cocina para niños", 24, 4000, "CocinaFamiliar", 500, "Jorge Muñoz"));
            libreria.AgregarArticulo(new Libro("Harry Potter y la piedra filosofal", 3, 12990, "Salamandra", 255, "J.K Rowling"));
            libreria.AgregarArticulo(new Libro("Harry Potter y la camara secreta", 4, 13990, "Salamandra", 286, "J.K Rowling"));
            libreria.AgregarArticulo(new Libro("Harry Potter y el prisionero de Azkaban", 4, 16990, "Salamandra", 359, "J.K Rowling"));
            libreria.AgregarArticulo(new Libro("Harry Potter y el cáliz de fuego", 3, 20990, "Salamandra", 636, "J.K Rowling"));
            libreria.AgregarArticulo(new Libro("Harry Potter y la orden del Fenix", 3, 25990, "Salamandra", 893, "J.K Rowling"));
            libreria.AgregarArticulo(new Libro("Harry Potter y el principe mestizo", 3, 23990, "Salamandra", 602, "J.K Rowling"));
            libreria.AgregarArticulo(new Libro("Harry Potter y las reliquias de la muerte", 3, 22990, "Salamandra", 638, "J.K Rowling"));

            #endregion
            
            while (flag)
            {
                Console.WriteLine("1. Ver Productos\n" +
                                  "2. Ver información completa de un artículo\n" +
                                  "3. Comprar un artículo\n" +
                                  "4. Cerrar Programa\n ");
                Console.Write("Ingrese un numero de opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                while (opcion < 1 || opcion > 4)
                {
                    Console.Write("Ingrese una opcion valida: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }


                if (opcion == 1)
                {
                    libreria.VerArticulos();

                }

                else if (opcion == 2 || opcion == 3)
                {
                    Console.Write("Ingrese el id de un producto: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Articulo articulo = libreria.BuscarPorCodigo(id);
                    if (articulo == null)
                    {
                        Console.WriteLine("No se encuentra el Articulo. Error");
                        continue;
                    }
                    if (opcion == 2)
                    {
                        articulo.Informacion();
                    }
                    else
                    {
                        if(articulo.Comprar() == false)
                        {
                            Console.WriteLine("Ese artículo se encuentra agotado");
                            continue;
                        }
                        Console.WriteLine("¡La compra se ha realizado con éxito!");
                    }

                }

                else
                {
                    Console.WriteLine("Presione una tecla para salir");
                    Console.ReadKey();
                    flag = false;
                }
                Console.WriteLine("\n\n\n\n");
            }
            
        }
    }
}
