using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        private string _marca;
        private string _color;

        public string Color
        {
            get { return this._color; }
        }

        public string Marca
        {
            get { return this._marca; }
        }

        public Auto(string color,string marca)
        {
            this._marca = marca;
            this._color = color;
        }

        public static bool operator ==(Auto a,Auto b)
        {
            if (a.Marca == b.Marca && a.Color == b.Color)
                return true;

            return false;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if(obj is Auto)
            {
                if (this == (Auto)obj)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Marca: " + this._marca + " - Color: " + this._color;
        }
    }
}
