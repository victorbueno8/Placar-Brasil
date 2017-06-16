using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placar_Brasil.Classes
{
    sealed class Tecnico : ProfisionaisEquipe
    {
        private double anos_experiencia;

        public Tecnico(int id, string doc_identidade, string nome, string cidade_origem, double anos_experiencia) : base(id, doc_identidade, nome, cidade_origem)
        {
            this.anos_experiencia = anos_experiencia;
        }

        public Tecnico(int id,string doc_identidade,string nome,string cidade_origem, Equipe equipe,double anos_experiencia) : base(id,doc_identidade,nome,cidade_origem,equipe)
        {
            this.anos_experiencia = anos_experiencia;
        }

        public double Anos_experiencia
        {
            get
            {
                return anos_experiencia;
            }

            set
            {
                anos_experiencia = value;
            }
        }
    }
}
