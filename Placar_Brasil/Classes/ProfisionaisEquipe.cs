using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placar_Brasil.Classes
{
    abstract class ProfisionaisEquipe
    {
        private int id;
        private string doc_identidade;
        private string nome;
        private string cidade_origem;
        private Equipe equipe;

        public ProfisionaisEquipe(int id, string doc_identidade, string nome, string cidade_origem)
        {
            this.id = id;
            this.doc_identidade = doc_identidade;
            this.nome = nome;
            this.cidade_origem = cidade_origem;
        }

        public ProfisionaisEquipe(int id, string doc_identidade, string nome, string cidade_origem, Equipe equipe)
        {
            this.id = id;
            this.doc_identidade = doc_identidade;
            this.nome = nome;
            this.cidade_origem = cidade_origem;
            this.equipe = equipe;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Doc_identidade
        {
            get
            {
                return doc_identidade;
            }

            set
            {
                doc_identidade = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Cidade_origem
        {
            get
            {
                return cidade_origem;
            }

            set
            {
                cidade_origem = value;
            }
        }

        internal Equipe Equipe
        {
            get
            {
                return equipe;
            }

            set
            {
                equipe = value;
            }
        }
    }
}
