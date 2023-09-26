using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kenjhi
{
    public class CategoriaItem
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public CategoriaItem(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
        //no tocar esta clase, lo usamos para representarlo como cadena de texto. to string
    }
}
