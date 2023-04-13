using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterDog
{
    internal class Valores<Generico>
    {
        private Generico[] valor;
        private int TamanhoMax;
        private int Tamanho;

        public Valores(int maximo)
        {
            this.TamanhoMax = maximo;
            this.Tamanho = 0;
            valor = new Generico[TamanhoMax];
        }
        public Boolean inserirValor(Generico item)
        {
            Boolean ok = false;
            if (Tamanho < TamanhoMax)
            {
                valor[Tamanho] = item;
                Tamanho++;
                ok = true;
            }
            return ok;
        }
        public Generico getIndexValor(int index)
        {
            Generico result = default(Generico);

            if (index < this.Tamanho)
            {
                result = this.valor[index];
            }

            return result;
        }
        public int getTamanho()
        {
            return this.Tamanho;
        }

    }
}
