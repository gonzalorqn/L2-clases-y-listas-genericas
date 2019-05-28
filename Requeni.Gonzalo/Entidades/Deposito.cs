using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        public bool Agregar(T a)
        {
            bool retorno = false;
            if (this._lista.Count < this._capacidadMaxima)
            {
                this._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(T a)
        {
            return this._lista.IndexOf(a);
        }

        public bool Remover(T a)
        {
            bool retorno = false;
            int indice = this.GetIndice(a);
            if (indice != -1)
            {
                this._lista.RemoveAt(indice);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            return d.Agregar(a);
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            return d.Remover(a);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Capacidad máxima: " + this._capacidadMaxima);
            sb.AppendLine("Listado de " + typeof(T).Name + ":");
            foreach (T a in this._lista)
            {
                sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }
    }
}
