using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placar_Brasil.Forms
{
    public partial class Registrar : Form
    {
        enum FormStatus{ Neutro, Torcedor, Organizador}

        public string OldUser;
        public string UserMode;

        public Registrar()
        {
            InitializeComponent();
            edit_bt.Visible = false;
            cpf_label.Visible = false;
            cpf_tb.Enabled = false;
            cpf_tb.Visible = false;
            email_label.Visible = false;
            email_tb.Enabled = false;
            email_tb.Visible = false;
            time_lb.Visible = false;
            time_tb.Enabled = false;
            time_tb.Visible = false;
            autentificação_lb.Visible = false;
            Autentificacao_tb.Enabled = false;
            Autentificacao_tb.Visible = false;
            organização_lb.Visible = false;
            organização_tb.Enabled = false;
            organização_tb.Visible = false;
            função_lb.Visible = false;
            funcao_tb.Enabled = false;
            funcao_tb.Visible = false;

            time_tb.DataSource = (new Classes.EquipeDAO()).SelectBD("");
            time_tb.DisplayMember = "nome";
            time_tb.SelectedIndex = -1;

            senha_tb.PasswordChar = '*';
            confsenha_tb.PasswordChar = '*';
        }

        private void ControlarComponentes(FormStatus status)
        {
            cpf_label.Visible = status == FormStatus.Torcedor ? true : false;
            cpf_tb.Enabled = status == FormStatus.Torcedor ? true : false;
            cpf_tb.Visible = status == FormStatus.Torcedor ? true : false;
            email_label.Visible = status == FormStatus.Torcedor ? true : false;
            email_tb.Enabled = status == FormStatus.Torcedor ? true : false;
            email_tb.Visible = status == FormStatus.Torcedor ? true : false;
            time_lb.Visible = status == FormStatus.Torcedor ? true : false;
            time_tb.Enabled = status == FormStatus.Torcedor ? true : false;
            time_tb.Visible = status == FormStatus.Torcedor ? true : false;
            autentificação_lb.Visible = status == FormStatus.Organizador ? true : false;
            Autentificacao_tb.Enabled = status == FormStatus.Organizador ? true : false;
            Autentificacao_tb.Visible = status == FormStatus.Organizador ? true : false;
            organização_lb.Visible = status == FormStatus.Organizador ? true : false;
            organização_tb.Enabled = status == FormStatus.Organizador ? true : false;
            organização_tb.Visible = status == FormStatus.Organizador ? true : false;
            função_lb.Visible = status == FormStatus.Organizador ? true : false;
            funcao_tb.Enabled = status == FormStatus.Organizador ? true : false;
            funcao_tb.Visible = status == FormStatus.Organizador ? true : false;
        }

        private void registrar_bt_Click(object sender, EventArgs e)
        {
            int id = 0; //valor irá ser alterado na DAO
            string nome = nome_tb.Text;
            string usuario = usuario_tb.Text;
            string senha = senha_tb.Text;
            string csenha = confsenha_tb.Text;
            string email = email_tb.Text;
            string nome_completo = nome_completo_tb.Text;
            string cpf = cpf_tb.Text;
            string time = time_tb.Text;
            string autenticacao = "000321123abc";      //A autenticação deve corresponder a esse número
            string organizacao = organização_tb.Text;
            string funcao = funcao_tb.Text;

            if(torcedor.Checked == true)
            {
                Classes.Torcedores t = new Classes.Torcedores(id, usuario, senha, nome_completo, cpf, email, time);
                Classes.TorcedorDAO tDAO = new Classes.TorcedorDAO();
                
                if (nome == "" || usuario == "" || senha == "" || csenha == "" || email == "" || nome_completo == "" || cpf == "" || time == "")
                {
                    MessageBox.Show("Você deve preencher todos os campos");
                    return;
                }
                else if(tDAO.SelectBD(usuario).Count > 0)
                {
                    MessageBox.Show("Usuario já existente!");
                    return;
                }
                else if (senha != csenha)
                {
                    MessageBox.Show("Senhas não correspondem");
                    return;
                }
                else
                {
                    
                    tDAO.InsertBD(t);
                    Close();
                }
            }

            if(organizador.Checked == true)
            {
                if (nome == "" || usuario == "" || senha == "" || csenha == "" || autenticacao == "" || nome_completo == "" || organizacao == "" || funcao == "")
                {
                    MessageBox.Show("Você deve preencher todos os campos");
                    return;
                }
                else if (senha != csenha)
                {
                    MessageBox.Show("Senhas não correspondem");
                    return;
                }
                else if (Autentificacao_tb.Text != autenticacao) //So pode se cadastrar quem possui o código de autentificação
                {
                    MessageBox.Show("Numero de autentificação não válido!");
                    return;
                }
                else
                {
                    Classes.Organizadores t = new Classes.Organizadores(id, usuario, senha, nome_completo, autenticacao, organizacao, funcao);
                    Classes.OrganizadorDAO tDAO = new Classes.OrganizadorDAO();
                    tDAO.InsertBD(t);
                    Close();
                }
            }

            


        }

        private void torcedor_CheckedChanged(object sender, EventArgs e)
        {
            ControlarComponentes(FormStatus.Torcedor);
        }

        private void organizador_CheckedChanged(object sender, EventArgs e)
        {
            ControlarComponentes(FormStatus.Organizador);
        }

        public void TorcedorEditMode(string nomeUsuario)
        {
            Classes.Torcedores t = new Classes.TorcedorDAO().SelectBD(nomeUsuario)[0];
            nome_tb.Enabled = false;
            OldUser = t.Nome_usuario;
            UserMode = "Torcedor";
            nome_completo_tb.Text = t.Nome_completo;
            usuario_tb.Text = t.Nome_usuario;
            senha_tb.Text = t.Senha;
            cpf_tb.Text = t.Cpf;
            email_tb.Text = t.Email;
            time_tb.Text = t.Time;
            ControlarComponentes(FormStatus.Torcedor);
            edit_bt.Visible = true;
            registrar_bt.Visible = false;
            organizador.Enabled = false;
            torcedor.Enabled = false;
        }

        public void OrganizadorEditMode(string nomeUsuario)
        {
            Classes.Organizadores t = new Classes.OrganizadorDAO().SelectBD(nomeUsuario)[0];
            nome_tb.Enabled = false;
            OldUser = t.Nome_usuario;
            UserMode = "Organizador";
            nome_completo_tb.Text = t.Nome_completo;
            usuario_tb.Text = t.Nome_usuario;
            senha_tb.Text = t.Senha;
            Autentificacao_tb.Text = t.Cod_autentificação;
            organização_tb.Text = t.Organização ;
            funcao_tb.Text = t.Função;
            ControlarComponentes(FormStatus.Organizador);
            edit_bt.Visible = true;
            registrar_bt.Visible = false;
            organizador.Enabled = false;
            torcedor.Enabled = false;
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
            Console.WriteLine(UserMode);
            if (UserMode == "Torcedor")
            {
                if (usuario_tb.Text == "" || senha_tb.Text == "" || confsenha_tb.Text == "" || nome_completo_tb.Text == "" || cpf_tb.Text == "" || email_tb.Text == "" || time_tb.Text == "")
                {
                    MessageBox.Show("Preencha todos Campos!");
                    return;
                }
                else
                {
                    Classes.TorcedorDAO cDAO = new Classes.TorcedorDAO();
                    Classes.Torcedores c = new Classes.Torcedores(cDAO.SelectBD(OldUser)[0].Id, usuario_tb.Text, senha_tb.Text, nome_completo_tb.Text, cpf_tb.Text, email_tb.Text, time_tb.Text);
                    cDAO.UpdateBD(cDAO.SelectBD(OldUser)[0].Nome_usuario, c);
                    Close();
                }
            }
            if (UserMode == "Organizador")
            {
                if (usuario_tb.Text == "" || senha_tb.Text == "" || confsenha_tb.Text == "" || nome_completo_tb.Text == "" || Autentificacao_tb.Text == "" || organização_tb.Text == "" || funcao_tb.Text == "")
                {
                    MessageBox.Show("Preencha todos Campos!");
                    return;
                }
                else
                {
                    Classes.OrganizadorDAO tDAO = new Classes.OrganizadorDAO();
                    Classes.Organizadores c = new Classes.Organizadores(tDAO.SelectBD(OldUser)[0].Id, usuario_tb.Text, senha_tb.Text, nome_completo_tb.Text, Autentificacao_tb.Text, organização_tb.Text, funcao_tb.Text);
                    tDAO.UpdateBD(tDAO.SelectBD(OldUser)[0].Nome_usuario, c);
                    Close();
                }
            }
        }
    }
}
