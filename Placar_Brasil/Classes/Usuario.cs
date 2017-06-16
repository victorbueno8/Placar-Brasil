using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placar_Brasil.Classes
{
    abstract class Usuario
    {
        private int id;
        private string nome_usuario;
        private string senha;
        private string nome_completo;

        public Usuario(int id, string nome_usuario, string senha, string nome_completo)
        {
            this.id = id;
            this.nome_usuario = nome_usuario;
            this.senha = senha;
            this.nome_completo = nome_completo;
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

        public string Nome_usuario
        {
            get
            {
                return nome_usuario;
            }

            set
            {
                nome_usuario = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public string Nome_completo
        {
            get
            {
                return nome_completo;
            }

            set
            {
                nome_completo = value;
            }
        }
        
    }
}
