using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placar_Brasil
{
    public partial class Login : Form
    {
        public static string userName;

        public Login()
        {
            InitializeComponent();
            tb_senha.Text = "";
            tb_senha.PasswordChar = '*';
            LoginEnter.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Registrar rg = new Forms.Registrar();
            rg.ShowDialog();
        }

        private void LoginEnter_Click(object sender, EventArgs e)
        {
            string username = tb_usuario.Text;
            string password = tb_senha.Text;
            userName = tb_usuario.Text;

            if(torcedor_rb.Checked == true)
            {
                Classes.TorcedorDAO tDAO = new Classes.TorcedorDAO();
                

                if (tDAO.SelectBD(username).Count == 1)
                {
                    Classes.Torcedores user = tDAO.SelectBD(username)[0];
                    if (password == user.Senha)
                    {
                        Forms.Main_Menu_Torcedor tmm = new Forms.Main_Menu_Torcedor();
                        Hide();
                        tmm.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Senha errada!");
                        return;
                    }
                } 
                else
                {
                    MessageBox.Show("Usuario não cadastrado!");
                    return;
                }
            }

            if (organizador_rb.Checked == true)
            {
                Classes.OrganizadorDAO tDAO = new Classes.OrganizadorDAO();
                
                if(tDAO.SelectBD(username).Count == 1)
                {
                    Classes.Organizadores user = tDAO.SelectBD(username)[0];
                    if (password == user.Senha)
                    {
                        Forms.Main_Menu_Organizador omm = new Forms.Main_Menu_Organizador();
                        Hide();
                        omm.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Senha errada!");
                        return;
                    }
                }
                else
                {
                      MessageBox.Show("Usuario não cadastrado!");
                      return;
                }

            }
        }

        private void torcedor_rb_CheckedChanged(object sender, EventArgs e)
        {
            LoginEnter.Enabled = true;
        }

        private void organizador_rb_CheckedChanged(object sender, EventArgs e)
        {
            LoginEnter.Enabled = true;
        }
    }
}
