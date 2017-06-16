using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placar_Brasil.Classes
{
    sealed class Organizadores : Usuario
    {
        private string cod_autentificação;
        private string organização;         //entidade responsavel
        private string função;              //função da autoridade

        public Organizadores(int id, string nome_usuario, string senha, string nome_completo, string cod_autentificação, string organização, string função) : base(id,nome_usuario,senha,nome_completo)
        {
            this.cod_autentificação = cod_autentificação;
            this.Organização = organização;
            this.função = função;
        }

        public string Cod_autentificação
        {
            get
            {
                return cod_autentificação;
            }

            set
            {
                cod_autentificação = value;
            }
        }

        public string Função
        {
            get
            {
                return função;
            }

            set
            {
                função = value;
            }
        }

        public string Organização
        {
            get
            {
                return organização;
            }

            set
            {
                organização = value;
            }
        }
    }
}
