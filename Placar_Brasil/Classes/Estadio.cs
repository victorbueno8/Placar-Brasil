using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placar_Brasil.Classes
{
    class Estadio
    {
        private int id;
        private string nome;
        private string cidade;
        private string estado;

        public Estadio(int id, string nome, string cidade, string estado)
        {
            this.id = id;
            this.nome = nome;
            this.cidade = cidade;
            this.estado = estado;
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

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
    }
}
