using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_Banco_de_Dados_Parte_3
{
    class Medico
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
}
