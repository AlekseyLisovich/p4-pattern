using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AlchemistCauldron
{
    public class Formula
    {
        public string[] Elements { get; set; }

        public string Result { get; set; }

        public Formula(string[] element, string result)
        {
            Elements = element;
            Result = result;
        }
    }
}