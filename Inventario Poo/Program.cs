using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_Poo
{
    class Program
    {
        static void Main()
        {
            Inventario inventario = new Inventario();
            Cliente cliente = new Cliente("C001", "Anthony Peña", "Anthonypmatinez@gmail.com");

            int opcion;
            do
            {
                Console.WriteLine("\n Menú Principal ");
                Console.WriteLine("1. Agregar Artículo");
                Console.WriteLine("2. Mostrar Inventario");
                Console.WriteLine("3. Buscar Artículo");
                Console.WriteLine("4. Modificar Artículo");
                Console.WriteLine("5. Mostrar Cliente");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción no válida.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Código: ");
                        string codigo = Console.ReadLine();
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Precio: ");
                        decimal precio = decimal.Parse(Console.ReadLine());
                        Console.Write("Stock: ");
                        int stock = int.Parse(Console.ReadLine());
                        inventario.AgregarArticulo(new Articulo(codigo, nombre, precio, stock));
                        break;

                    case 2:
                        inventario.MostrarInventario();
                        break;

                    case 3:
                        Console.Write("Ingrese el código del artículo a buscar: ");
                        string buscarCodigo = Console.ReadLine();
                        Articulo encontrado = inventario.BuscarArticulo(buscarCodigo);
                        if (encontrado != null)
                            encontrado.MostrarInfo();
                        else
                            Console.WriteLine("Artículo no encontrado.");
                        break;

                    case 4:
                        Console.Write("Código del artículo a modificar: ");
                        string modCodigo = Console.ReadLine();
                        Console.Write("Nuevo precio: ");
                        decimal nuevoPrecio = decimal.Parse(Console.ReadLine());
                        Console.Write("Nuevo stock: ");
                        int nuevoStock = int.Parse(Console.ReadLine());
                        inventario.ModificarArticulo(modCodigo, nuevoPrecio, nuevoStock);
                        break;

                    case 5:
                        cliente.MostrarCliente();
                        break;

                    case 6:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 6);
        }
    }




}
