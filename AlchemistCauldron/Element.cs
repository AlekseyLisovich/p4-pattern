using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemistCauldron
{
    public class Element
    {
        public string Value { get; set; }

        public int Index { get; set; }

        public Element(string value, int index)
        {
            Value = value;
            Index = index;
        }
    }
}