using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        public bool Agregar(Cocina a)
        {
            bool retorno = false;
            if (this._lista.Count < this._capacidadMaxima)
            {
                this._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(Cocina a)
        {
            return this._lista.IndexOf(a);
        }

        public bool Remover(Cocina a)
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

        public static bool operator +(DepositoDeCocinas d, Cocina a)
        {
            return d.Agregar(a);
        }

        public static bool operator -(DepositoDeCocinas d, Cocina a)
        {
            return d.Remover(a);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Capacidad máxima: " + this._capacidadMaxima);
            sb.AppendLine("Listado de Cocinas:");
            foreach (Cocina a in this._lista)
            {
                sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }
    }
}
