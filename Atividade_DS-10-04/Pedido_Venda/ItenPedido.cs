using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido_Venda
{
    class ItenPedido
    {
        private int quantidade;
        private double preco;

        public int Quantidade
        {
            set
            {
                this.quantidade = value;
            }
            get
            {
                return quantidade;
            }
        }

        public double Preco
        {
            set
            {
                this.preco = value;
            }
            get
            {
                return preco;
            }
        }

        public int incluitItem()
        {

            string quant = Convert.ToString(Quantidade);
            Console.WriteLine("QUAL É A QUANTIDADE DO PEDIDO: ");
            quant = Console.ReadLine();
            Console.WriteLine("QUANTIDADE DO PEDIDO DO PEDIDO É: " + quant);

            string precos = Convert.ToString(preco);
            Console.WriteLine("QUAL É PREÇO DO PRODUTO: ");
            precos = Console.ReadLine();
            Console.WriteLine("PREÇO DO PRODUTO É: " + precos);



            return Quantidade;
        }

        public int excluirItem()
        {
            return 0;
        }
    }
}
