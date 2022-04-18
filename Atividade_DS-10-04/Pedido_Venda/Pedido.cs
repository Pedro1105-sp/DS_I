using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido_Venda
{
    class Pedido
    {
        private string vendedor;
        private bool status;
        private string observacao;
        private DateTime dataPedido;

        public string Vendedor
        {
            set
            {
                this.vendedor = value;
            }
            get
            {
                return vendedor;
            }
        }

        public bool Status
        {
            set
            {
                this.status = value;
            }
            get
            {
                return status;
            }
        }

        public string Observacao
        {
            set
            {
                this.observacao = value;
            }
            get
            {
                return observacao;
            }
        }

        public DateTime DataPedido
        {
            set
            {
                this.dataPedido = value;
            }
            get
            {
                return dataPedido;
            }
        }

        public void encerrarPedido()
        {
            //
        }

        public void cancelarPedido()
        {
            //
        }

        public void criarPedido()
        {
        }
    }
}
