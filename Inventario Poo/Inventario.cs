using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_Poo
{
    public class Inventario : Articulo
    {
        private Articulo[] articulos = new Articulo[50];
        private int contador = 0;

        public Inventario() : base("", "", 0, 0) { }

        public void AgregarArticulo(Articulo nuevo)
        {
            if (contador < articulos.Length)
            {
                articulos[contador++] = nuevo;
                Console.WriteLine("Artículo agregado con éxito.");
            }
            else
            {
                Console.WriteLine("Inventario lleno. No se pueden agregar más artículos.");
            }
        }

        public void MostrarInventario()
        {
            if (contador == 0)
            {
                Console.WriteLine("Inventario vacío.");
                return;
            }

            Console.WriteLine("Lista de artículos en inventario:");
            for (int i = 0; i < contador; i++)
            {
                articulos[i].MostrarInfo();
            }
        }

        public Articulo BuscarArticulo(string codigo)
        {
            for (int i = 0; i < contador; i++)
            {
                if (articulos[i].Codigo == codigo)
                {
                    return articulos[i];
                }
            }
            return null;
        }

        public void ModificarArticulo(string codigo, decimal nuevoPrecio, int nuevoStock)
        {
            Articulo articulo = BuscarArticulo(codigo);
            if (articulo != null)
            {
                articulo.Precio = nuevoPrecio;
                articulo.Stock = nuevoStock;
                Console.WriteLine("Artículo modificado con éxito.");
            }
            else
            {
                Console.WriteLine("Artículo no encontrado.");
            }
        }
    }



}
