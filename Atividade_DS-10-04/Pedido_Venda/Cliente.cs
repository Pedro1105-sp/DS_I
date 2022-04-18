using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido_Venda
{
    class Cliente
    {
        private double limiteCredito;
        private int cartaoCredito;
        private string contato;
        private bool status;

        public double LimiteCredito
        {
            set
            {
                this.limiteCredito = value;
            }
            get
            {
                return limiteCredito;
            }
        }

        public int CartaoCredito
        {
            set
            {
                this.cartaoCredito = value;
            }
            get
            {
                return cartaoCredito;
            }
        }

        public string Contato
        {
            set
            {
                this.contato = value;
            }
            get
            {
                return contato;
          …
using System;

namespace DS_C_
    {

        class Pessoa
        {
            private string nome;
            private DateTime dataNasc;

            public string Nome
            {
                set
                {
                    this.nome = value;
                }
                get
                {
                    return nome;
                }
            }

            public DateTime DataNasc
            {
                set
                {
                    this.dataNasc = value;
                }
                get
                {
                    return dataNasc;
                }
            }

            public int calcularIdade()
            {
                return 0;
            }
        }
}
