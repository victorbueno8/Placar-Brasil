using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placar_Brasil.Classes
{
    class Torcedores : Usuario
    {
        private string cpf;
        private string email;
        private string time;

        public Torcedores(int id, string nome_usuario, string senha, string nome_completo, string cpf, string email, string time) : base(id, nome_usuario, senha, nome_completo)
        {
            this.cpf = cpf;
            this.email = email;
            this.time = time;
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }
    }
}
