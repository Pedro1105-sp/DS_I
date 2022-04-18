using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido_Venda
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

        public int calcularIdade(int DataNasc)
        {
            int  resultado = (2022 - DataNasc);

            Console.WriteLine("DIGITE SEU NOME: ");
            Nome = Console.ReadLine();

            Console.WriteLine("EM QUAL ANO VOCÊ NASCEU: " + DataNasc);
            string data = Convert.ToString(DataNasc);
            data = Console.ReadLine();


            Console.WriteLine("SUA IDADE É: " + resultado);
            return resultado;
            
        }

    }
}

