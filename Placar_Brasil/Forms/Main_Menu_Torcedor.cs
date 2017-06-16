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
    public partial class Main_Menu_Torcedor : Form
    {


        public Main_Menu_Torcedor()
        {
            InitializeComponent();
            Pesquisa_tb.Enabled = false;
            pesquisa_bt.Enabled = false;
            tipo_pesquisa_cb.Items.Add("Campeonatos");
            tipo_pesquisa_cb.Items.Add("Equipes");
            tipo_pesquisa_cb.Items.Add("Jogadores");
            tipo_pesquisa_cb.Items.Add("Estádios");
            tipo_pesquisa_cb.Items.Add("Técnicos");
            tipo_pesquisa_cb.Items.Add("Jogos");
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        { }

        private void tipo_pesquisa_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pesquisa_tb.Enabled = true;
            pesquisa_bt.Enabled = true;
            Pesquisa_tb.Clear();
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void pesquisa_bt_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            switch (tipo_pesquisa_cb.Text)
            {
                case "Campeonatos":
                    dataGridView1.DataSource = new Classes.CampeonatoDAO().SelectBD(Pesquisa_tb.Text);
                    break;
                case "Equipes":
                    dataGridView1.DataSource = new Classes.EquipeDAO().SelectBD(Pesquisa_tb.Text);
                    break;
                case "Jogadores":
                    List<Classes.Jogador> listjogador = new Classes.JogadorDAO().SelectBD(Pesquisa_tb.Text);
                    dataGridView1.Columns.Add("id", "id");
                    dataGridView1.Columns.Add("nome", "Nome");
                    dataGridView1.Columns.Add("doc_identidade", "Documento");
                    dataGridView1.Columns.Add("cidade_origem", "Cidade de Origem");
                    dataGridView1.Columns.Add("posicao", "Posição");
                    dataGridView1.Columns.Add("apelido", "Apelido");
                    dataGridView1.Columns.Add("nomeEquipe", "Equipe");
                    foreach (Classes.Jogador j in listjogador)
                    {
                        dataGridView1.Rows.Add(j.Id, j.Nome, j.Doc_identidade, j.Cidade_origem, j.Posicao, j.Apelido, j.Equipe.Nome);
                    }
                    break;
                case "Estádios":
                    dataGridView1.DataSource = new Classes.EstadioDAO().SelectBD(Pesquisa_tb.Text);
                    break;
                case "Técnicos":
                    List<Classes.Tecnico> listtecnico = new Classes.TecnicoDAO().SelectBD(Pesquisa_tb.Text);
                    dataGridView1.Columns.Add("id", "id");
                    dataGridView1.Columns.Add("nome", "Nome");
                    dataGridView1.Columns.Add("doc_identidade", "Documento");
                    dataGridView1.Columns.Add("cidade_origem", "Cidade de Origem");
                    dataGridView1.Columns.Add("anos_experiencia", "Anos de Experiência");
                    dataGridView1.Columns.Add("nomeEquipe", "Equipe");
                    foreach (Classes.Tecnico j in listtecnico)
                    {
                        dataGridView1.Rows.Add(j.Id, j.Nome, j.Doc_identidade, j.Cidade_origem, j.Anos_experiencia, j.Equipe.Nome);
                    }

                    break;
                case "Jogos":
                    List<Classes.Jogo> listjogo = new Classes.JogoDAO().SelectBD(Pesquisa_tb.Text);

                    dataGridView1.Columns.Add("id_jogo", "id");
                    dataGridView1.Columns.Add("nomeequipeCasa", "Equipe Casa");
                    dataGridView1.Columns.Add("golsequipeCasa", "Gols Casa");
                    dataGridView1.Columns.Add("nomeEquipeFora", "Equipe Fora");
                    dataGridView1.Columns.Add("golsequipefora", "Gols Fora");
                    dataGridView1.Columns.Add("nomelocal", "Local");
                    dataGridView1.Columns.Add("nomeCampeonato", "Campeonato");
                    dataGridView1.Columns.Add("nomeUsuario", "Responsavel");

                    foreach (Classes.Jogo j in listjogo)
                    {
                        dataGridView1.Rows.Add(j.Id, j.EquipeCasa.Nome, j.GolsEquipeCasa, j.EquipeFora.Nome, j.GolsEquipeFora, j.Local.Nome, j.Campeonato.Nome, j.Responsavel.Nome_usuario);
                    }
                    break;
            }
            dataGridView1.ClearSelection();
        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Registrar r = new Registrar();
            r.Show();
            r.TorcedorEditMode(Login.userName);
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deletarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes.TorcedorDAO oDAO = new Classes.TorcedorDAO();
            if (MessageBox.Show("Deseja deletar sua conta?", "Deletar Conta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                oDAO.DeleteBD(Login.userName);
                Login l = new Login();
                Hide();
                l.ShowDialog();
                Close();
            }
            else
            {
                return;
            }
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }

        private void Main_Menu_Torcedor_Load(object sender, EventArgs e)
        {
            Classes.Torcedores tor = new Classes.TorcedorDAO().SelectBD(Login.userName)[0];
            NomeCompleto_lb.Text = tor.Nome_completo;
            email_lb.Text = "Email: " + tor.Email;
            id_lb.Text = "ID: " + Convert.ToString(tor.Id);
            TimeTorce_lb.Text = "Torcedor do " + tor.Time;

            List<Classes.Jogo> listjogo = new Classes.JogoDAO().SelectBD(tor.Time);

            dataGridView1.Columns.Add("id_jogo", "id");
            dataGridView1.Columns.Add("nomeequipeCasa", "Equipe Casa");
            dataGridView1.Columns.Add("golsequipeCasa", "Gols Casa");
            dataGridView1.Columns.Add("nomeEquipeFora", "Equipe Fora");
            dataGridView1.Columns.Add("golsequipefora", "Gols Fora");
            dataGridView1.Columns.Add("nomelocal", "Local");
            dataGridView1.Columns.Add("nomeCampeonato", "Campeonato");
            dataGridView1.Columns.Add("nomeUsuario", "Responsavel");

            foreach (Classes.Jogo j in listjogo)
            {
                dataGridView1.Rows.Add(j.Id, j.EquipeCasa.Nome, j.GolsEquipeCasa, j.EquipeFora.Nome, j.GolsEquipeFora, j.Local.Nome, j.Campeonato.Nome, j.Responsavel.Nome_usuario);
            }
        }
    }
}
