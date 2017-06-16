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
    public partial class EditEquipeJogadorTecnico : Form
    {
        enum FormStatus{ Neutro, Jogador, Tecnico}

        public string Cnome;
        public string Edit;

        public EditEquipeJogadorTecnico()
        {
            InitializeComponent();
            ControlaComponentes(FormStatus.Neutro);
            equipeNome_tb.DataSource = (new Classes.EquipeDAO()).SelectBD("");
            equipeNome_tb.DisplayMember = "nome";
            equipeNome_tb.SelectedIndex = -1;
            edit_bt.Visible = false;
        }

        private void ControlaComponentes(FormStatus status)
        {
            equipeNome_tb.Enabled = status == FormStatus.Neutro || status == FormStatus.Jogador || status == FormStatus.Tecnico ? true : false;
            nome_tb.Enabled = status == FormStatus.Jogador || status == FormStatus.Tecnico ? true : false;
            docidentidade_tb.Enabled = status == FormStatus.Jogador || status == FormStatus.Tecnico ? true : false;
            cidade_origem_tb.Enabled = status == FormStatus.Jogador || status == FormStatus.Tecnico ? true : false;
            apelido_lb.Visible = status == FormStatus.Jogador ? true : false;
            apelido_tb.Visible = status == FormStatus.Jogador ? true : false;
            posicao_lb.Visible = status == FormStatus.Jogador ? true : false;
            posicao_tb.Visible = status == FormStatus.Jogador ? true : false;
            anoexp_lb.Visible = status == FormStatus.Tecnico ? true : false;
            anosexp_tb.Visible = status == FormStatus.Tecnico ? true : false;
        }

        private void jogador_checkbutton_CheckedChanged(object sender, EventArgs e)
        {
            ControlaComponentes(FormStatus.Jogador);
        }

        private void tecnico_checkedbutton_CheckedChanged(object sender, EventArgs e)
        {
            ControlaComponentes(FormStatus.Tecnico);
        }

        private void Confirma_Click(object sender, EventArgs e)
        {
            Classes.EquipeDAO eDAO = new Classes.EquipeDAO();
            if (eDAO.SelectBD(equipeNome_tb.Text).Count == 0 && equipeNome_tb.Text != "")
            {
                Classes.Equipe equipe = new Classes.Equipe(Banco_de_Dados.AutoIncrementaId("Equipe", "id"), equipeNome_tb.Text);

                Console.WriteLine(equipe.Nome);
                eDAO.InsertBD(equipe);
            }

            if(jogador_checkbutton.Checked == true)
            {
                if (nome_tb.Text != "" && docidentidade_tb.Text != "" && cidade_origem_tb.Text != "" && apelido_tb.Text != "" && posicao_tb.Text != "" && equipeNome_tb.Text != "")
                {
                    Classes.JogadorDAO jDAO = new Classes.JogadorDAO();
                    Classes.Jogador j = new Classes.Jogador(Banco_de_Dados.AutoIncrementaId("ProfisionaisEquipe", "id"), docidentidade_tb.Text, nome_tb.Text, cidade_origem_tb.Text, eDAO.SelectBD(equipeNome_tb.Text)[0], apelido_tb.Text, posicao_tb.Text);
                    jDAO.InsertBD(j);
                }
                else
                {
                    MessageBox.Show("Preencha todos campos");
                    return;
                }
            }
            

            if(tecnico_checkedbutton.Checked == true)
            {
                if (nome_tb.Text != "" && docidentidade_tb.Text != "" && cidade_origem_tb.Text != "" && anosexp_tb.Text != "" && equipeNome_tb.Text != "")
                {
                    Classes.TecnicoDAO tDAO = new Classes.TecnicoDAO();
                    Classes.Tecnico t = new Classes.Tecnico(Banco_de_Dados.AutoIncrementaId("ProfisionaisEquipe", "id"), docidentidade_tb.Text, nome_tb.Text, cidade_origem_tb.Text, eDAO.SelectBD(equipeNome_tb.Text)[0], Convert.ToDouble(anosexp_tb.Text));
                    tDAO.InsertBD(t);
                }
                else
                {
                    MessageBox.Show("Preencha todos campos");
                    return;
                }
            }
            

            Close();
        }

        public void JogadorEditMode(string nome)
        {
            Classes.Jogador c = new Classes.JogadorDAO().SelectBD(nome)[0];
            this.Cnome = c.Nome;
            this.Edit = "Jogador";
            nome_tb.Text = c.Nome;
            docidentidade_tb.Text = c.Doc_identidade;
            cidade_origem_tb.Text = c.Cidade_origem;
            apelido_tb.Text = c.Apelido;
            posicao_tb.Text = c.Posicao;
            equipeNome_tb.Text = c.Equipe.Nome;
            ControlaComponentes(FormStatus.Jogador);
            edit_bt.Visible = true;
            Confirma.Visible = false;
            jogador_checkbutton.Enabled = false;
            tecnico_checkedbutton.Enabled = false;
        }

        public void EquipeEditMode(string nome)
        {
            Classes.Equipe c = new Classes.EquipeDAO().SelectBD(nome)[0];
            this.Cnome = c.Nome;
            this.Edit = "Equipe";
            equipeNome_tb.Text = c.Nome;
            ControlaComponentes(FormStatus.Neutro);
            edit_bt.Visible = true;
            Confirma.Visible = false;
            jogador_checkbutton.Enabled = false;
            tecnico_checkedbutton.Enabled = false;
        }

        public void TecnicoEditMode(string nome)
        {
            Classes.Tecnico c = new Classes.TecnicoDAO().SelectBD(nome)[0];
            this.Cnome = c.Nome;
            this.Edit = "Tecnico";
            nome_tb.Text = c.Nome;
            docidentidade_tb.Text = c.Doc_identidade;
            cidade_origem_tb.Text = c.Cidade_origem;
            anosexp_tb.Text = Convert.ToString(c.Anos_experiencia);
            equipeNome_tb.Text = c.Equipe.Nome;
            ControlaComponentes(FormStatus.Tecnico);
            edit_bt.Visible = true;
            Confirma.Visible = false;
            jogador_checkbutton.Enabled = false;
            tecnico_checkedbutton.Enabled = false;
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {

            if(Edit == "Equipe")
            {
                if (equipeNome_tb.Text == "")
                {
                    MessageBox.Show("Preencha todos Campos!");
                    return;
                }
                else
                {
                    Classes.EquipeDAO cDAO = new Classes.EquipeDAO();
                    Classes.Equipe c = new Classes.Equipe(cDAO.SelectBD(Cnome)[0].Id, equipeNome_tb.Text);
                    cDAO.UpdateBD(Cnome, c);
                    Close();
                }
            }
            if (Edit == "Jogador")
            {
                if (equipeNome_tb.Text == "" || nome_tb.Text == "" || docidentidade_tb.Text == "" || cidade_origem_tb.Text == "" || apelido_tb.Text == "" || posicao_tb.Text == "" || equipeNome_tb.Text == "")
                {
                    MessageBox.Show("Preencha todos Campos!");
                    return;
                }
                else
                {
                    Classes.JogadorDAO cDAO = new Classes.JogadorDAO();
                    Classes.Jogador c = new Classes.Jogador(cDAO.SelectBD(Cnome)[0].Id,docidentidade_tb.Text, nome_tb.Text, cidade_origem_tb.Text,new Classes.EquipeDAO().SelectBD(equipeNome_tb.Text)[0], apelido_tb.Text, posicao_tb.Text);
                    cDAO.UpdateBD(Cnome, c);
                    Close();
                }
            }
            if(Edit == "Tecnico")
            {
                if (equipeNome_tb.Text == "" || nome_tb.Text == "" || docidentidade_tb.Text == "" || cidade_origem_tb.Text == "" || anosexp_tb.Text == "" || equipeNome_tb.Text == "")
                {
                    MessageBox.Show("Preencha todos Campos!");
                    return;
                }
                else
                {
                    Console.WriteLine(Cnome);
                    Classes.TecnicoDAO tDAO = new Classes.TecnicoDAO();
                    Classes.Tecnico c = new Classes.Tecnico(tDAO.SelectBD(Cnome)[0].Id, docidentidade_tb.Text, nome_tb.Text, cidade_origem_tb.Text, new Classes.EquipeDAO().SelectBD(equipeNome_tb.Text)[0],Convert.ToDouble(anosexp_tb.Text));
                    tDAO.UpdateBD(tDAO.SelectBD(Cnome)[0].Nome, c);
                    Close();
                }
            }

        }
    }
}
