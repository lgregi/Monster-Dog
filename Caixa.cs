using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MonsterDog
{
    internal class Caixa
    {

        private double[] preco;
        private double[] dinheiro;
        private int tam;
        private int tamanho;
        private int TamanhoMax;
        Produtos Valores = new Produtos();

        public Caixa(int tam)
        {
            this.TamanhoMax = tam;
            this.tamanho = 0;
            this.dinheiro = new double[TamanhoMax];
            this.preco = new double[TamanhoMax];

        }
        public Double Conta(double Fechar)
        {
            double soma = 0;
            if (Fechar == 1)
            {
                soma = Valores.GetValor(0);
            }
            else if (Fechar == 2)
            {
                soma = Valores.GetValor(1);
            }
            else if (Fechar == 3)
            {
                soma = Valores.GetValor(2);
            }
            else if (Fechar == 4)
            {
                soma = Valores.GetValor(3);
            }
            return soma;
        }
        public bool InserirLancamento(double lancamento)
        {
            bool okay = false;
            if (tamanho < TamanhoMax)
            {
                preco[tamanho] = lancamento;
                tamanho++;
                okay = true;
            }
            return okay;
        }

        public double Fechamento()
        {
            double calc = 0;
            for (int i = 0; i < GetTamanho(); i++)
            {
                calc += preco[i];
            }
            return calc;

        }

        public int GetTamanho()
        {
            return this.tamanho;
        }
        public int GetConta()
        {
            return this.tam;
        }
        public bool contaprevia(double calcula)
        {
            bool ok = false;
            if (tam < TamanhoMax)
            {
                this.dinheiro[tam] = calcula;
                tam++;
                ok = true;
            }
            return ok;
        }

        public double TrazConta()
        {
            double soma = 0;
            for (int i = 0; i < GetConta(); i++)
            {
                soma += dinheiro[i];
            }
            return soma;
        }
        public void Zerarcontaprevia()
        {
            for (int i = 0; i < dinheiro.Length; i++)
            {
                dinheiro[i] = 0;
                tam = 0;
            }
        }





    }
}
