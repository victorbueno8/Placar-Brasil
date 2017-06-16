using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placar_Brasil.Classes
{
    class Campeonato
    {
        private int id;
        private string nome;
        private string abrangencia;
        private string descricao;

        public Campeonato(int id, string nome, string abrangencia, string descricao)
        {
            this.id = id;
            this.nome = nome;
            this.abrangencia = abrangencia;
            this.descricao = descricao;
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

        public string Abrangencia
        {
            get
            {
                return abrangencia;
            }

            set
            {
                abrangencia = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }
    }
}
