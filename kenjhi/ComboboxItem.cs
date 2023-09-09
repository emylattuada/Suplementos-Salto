using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kenjhi
{
    internal class ComboboxItem
    {
        //esta clase la usaremos para sacar el id exacto del item que elegimos en el form de hacer un nuevo ingreso
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboboxItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
