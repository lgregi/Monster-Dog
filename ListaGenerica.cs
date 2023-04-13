using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterDog
{
    internal class ListaGenerica<tipoGenerico>
    {
        private tipoGenerico[] Lista;
        private tipoGenerico[] Nome;
        private tipoGenerico[] valor;

        private int TamanhoMax;
        private int Tamanho;

        public ListaGenerica(int maximo)
        {
            this.TamanhoMax = maximo;
            this.Tamanho = 0;
            Lista = new tipoGenerico[this.TamanhoMax];
            Nome = new tipoGenerico[TamanhoMax];
            valor = new tipoGenerico[TamanhoMax];
        }

        public Boolean inserir(tipoGenerico item, tipoGenerico valor)
        {
            Boolean ok = false;
            if (Tamanho < TamanhoMax)
            {
                Lista[Tamanho] = item;
                Nome[Tamanho] = valor;
                Tamanho++;
                ok = true;
            }


            return ok;
        }
        public Boolean inserirValor(tipoGenerico item)
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


        public tipoGenerico getIndex(int index)
        {
            tipoGenerico result = default(tipoGenerico);

            if (index < this.Tamanho)
            {
                result = this.Lista[index];
            }

            return result;
        }

        public tipoGenerico getIndexNome(int index)
        {
            tipoGenerico result = default(tipoGenerico);

            if (index < this.Tamanho)
            {
                result = this.Nome[index];
            }

            return result;
        }
        public tipoGenerico getIndexValor(int index)
        {
            tipoGenerico result = default(tipoGenerico);

            if (index < this.Tamanho)
            {
                result = this.valor[index];
            }

            return result;
        }

        public bool inserirIndex(tipoGenerico item, int index)
        {
            bool ok = false;

            //Se tem Espaço no Vetor
            if (Tamanho < TamanhoMax)
            {
                if (index <= this.Tamanho)
                {
                    for (int i = Tamanho; i > index; i--)
                    {
                        Lista[i] = Lista[i - 1];
                    }
                    Lista[index] = item;
                    Tamanho++;
                    ok = true;
                }
            }
            return ok;

        }
        public tipoGenerico removerIndex(int index)
        {
            tipoGenerico result = default(tipoGenerico);

            if (index < this.Tamanho)
            {
                result = this.Lista[index];
                for (int i = index; i < this.Tamanho; i++)
                {
                    this.Lista[i] = this.Lista[i + 1];
                }
                this.Tamanho--;
            }

            return result;
        }

        public bool alterarIndex(tipoGenerico item, int index)
        {
            bool ok = false;
            if (index < Tamanho)
            {
                Lista[index] = item;
                ok = true;
            }
            return ok;
        }
        public int getTamanho()
        {
            return this.Tamanho;
        }
        public void imprimirlista()
        {


            for (int i = 0; i < getTamanho(); i++)
            {

                Console.WriteLine("ID" + getIndexNome(i) + ": " + getIndex(i) + " R$ " + getIndexValor(i));
            }
            //             {
            //                 Aluno aluno=TurmaADS.getIndex(i);
            //                 aluno.imprimirBoletim();
            //             }

            //            Console.ReadLine();
        }
    }
}
