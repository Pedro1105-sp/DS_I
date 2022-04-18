using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido_Venda
{
    class Produto
    {
        private string nomeProduto;
        private int peso;
        private int qntdeDisponivel;

        public string NomeProduto
        {
            set
            {
                this.nomeProduto = value;
            }
            get
            {
                return nomeProduto;
            }
        }

        public int Peso
        {
            set
            {
                this.peso = value;
            }
            get
            {
                return peso;
            }
        }

        public int QtdeDisponivel
        {
            set
            {
                this.qntdeDisponivel = value;
            }
            get
            {
                return qntdeDisponivel;
            }
        }

        public Produto consultarProduto()
        {
            Console.WriteLine("QUAL É O NOME DO PRODUTO: " + NomeProduto);
            NomeProduto = Console.ReadLine();

            Console.WriteLine("PESO DO PRODUTO: ");
            string pesos = Convert.ToString(Peso);
            pesos = Console.ReadLine();
            Console.WriteLine("PESO DO PRODUTO É: " + pesos);

            Console.WriteLine("QUANTIDADE DO PRODUTO: ");
            string qntd = Convert.ToString(QtdeDisponivel);
            qntd = Console.ReadLine();
            Console.WriteLine("QUANTIDADE DO PRODUTO É: " + qntd);

            return this;
        }

    }
}
