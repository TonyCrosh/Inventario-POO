using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_Poo
{
    public class Cliente
    {
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public Cliente(string idCliente, string nombre, string correo)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Correo = correo;
        }

        public void MostrarCliente()
        {
            Console.WriteLine($"ID: {IdCliente}, Nombre: {Nombre}, Correo: {Correo}");
        }
    }



}
