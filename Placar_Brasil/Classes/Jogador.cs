using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placar_Brasil.Classes
{
    sealed class Jogador : ProfisionaisEquipe
    {
        private string posicao;
        private string apelido;

        public Jogador(int id, string doc_identidade, string nome, string cidade_origem, string apelido, string posicao) : base(id, doc_identidade, nome, cidade_origem)
        {
            this.posicao = posicao;
            this.apelido = apelido;
        }

        public Jogador(int id,string doc_identidade,string nome,string cidade_origem, Equipe equipe,string apelido,string posicao) : base(id,doc_identidade,nome,cidade_origem,equipe)
        {
            this.posicao = posicao;
            this.apelido = apelido;
        }

        public string Posicao
        {
            get
            {
                return posicao;
            }

            set
            {
                posicao = value;
            }
        }

        public string Apelido
        {
            get
            {
                return apelido;
            }

            set
            {
                apelido = value;
            }
        }
    }
}
