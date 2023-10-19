using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kenjhi
{
    internal class Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Cliente(int id, string nombre, string telefono)
        {
            ID = id;
            Nombre = nombre;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Telefono}";
        }
    }
}
