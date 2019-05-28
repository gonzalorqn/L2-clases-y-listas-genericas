using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        public bool Agregar(Auto a)
        {
            bool retorno = false;
            if(this._lista.Count < this._capacidadMaxima)
            {
                this._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(Auto a)
        {
            return this._lista.IndexOf(a);
        }

        public bool Remover(Auto a)
        {
            bool retorno = false;
            int indice = this.GetIndice(a);
            if(indice != -1)
            {
                this._lista.RemoveAt(indice);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator +(DepositoDeAutos d,Auto a)
        {
            return d.Agregar(a);
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            return d.Remover(a);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Capacidad máxima: " + this._capacidadMaxima);
            sb.AppendLine("Listado de Autos:");
            foreach (Auto a in this._lista)
            {
                sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }
    }
}
