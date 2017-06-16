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
    public partial class Main_Menu_Organizador : Form
    {
        enum FormStatus { Pesquisa, Edicao }

        public Main_Menu_Organizador()
        {
            InitializeComponent();
            edit_bt.Enabled = false;
            delete_bt.Enabled = false;
            newReg_bt.Enabled = false;
            Pesquisa_tb.Enabled = false;
            pesquisa_bt.Enabled = false;
            tipo_pesquisa_cb.Items.Add("Campeonatos");
            tipo_pesquisa_cb.Items.Add("Equipes");
            tipo_pesquisa_cb.Items.Add("Jogadores");
            tipo_pesquisa_cb.Items.Add("Estádios");
            tipo_pesquisa_cb.Items.Add("Técnicos");
            tipo_pesquisa_cb.Items.Add("Jogos");

            Console.WriteLine(Login.userName);
        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Placar p = new Placar();
            p.Show();
        }

        private void ControlarComponentes(FormStatus status)
        {
            pesquisa_bt.Enabled = status == FormStatus.Pesquisa ? true : false;
            edit_bt.Enabled = status == FormStatus.Edicao ? true : false;
            delete_bt.Enabled = status == FormStatus.Edicao ? true : false;
            newReg_bt.Enabled = status == FormStatus.Pesquisa ? true : false;
        }

        private void tipo_pesquisa_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pesquisa_tb.Enabled = true;
            Pesquisa_tb.Clear();
            dataGridView1.DataSource = null;
            ControlarComponentes(FormStatus.Pesquisa);

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
                        dataGridView1.Rows.Add(j.Id,j.EquipeCasa.Nome,j.GolsEquipeCasa,j.EquipeFora.Nome,j.GolsEquipeFora,j.Local.Nome,j.Campeonato.Nome,j.Responsavel.Nome_usuario);
                    }
                    break;
            }
            dataGridView1.ClearSelection();
        }

        private void newgame_bt_Click(object sender, EventArgs e)
        {
            Placar p = new Placar();
            p.Show();
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1) // Se selecionou a célula
            {
                switch (tipo_pesquisa_cb.Text)
                {
                    case "Campeonatos":
                        Classes.CampeonatoDAO cDAO = new Classes.CampeonatoDAO();
                            if (cDAO.SelectBD(Pesquisa_tb.Text).Count == 1)
                            {
                                EditCampeonato ec = new EditCampeonato();
                                ec.Show();
                                ec.CampeonatoEditMode(Pesquisa_tb.Text);
                            }
                            else
                            { MessageBox.Show("Nome não encontrado!"); return; }
                        break;
                    case "Equipes":
                        Classes.EquipeDAO sDAO = new Classes.EquipeDAO();
                        if (sDAO.SelectBD(Pesquisa_tb.Text).Count == 1)
                        {
                            EditEquipeJogadorTecnico ec = new EditEquipeJogadorTecnico();
                            ec.Show();
                            ec.EquipeEditMode(Pesquisa_tb.Text);
                        }
                        else
                        { MessageBox.Show("Nome não encontrado!"); return; }
                        break;
                    case "Jogadores":
                        Classes.JogadorDAO jDAO = new Classes.JogadorDAO();
                        if (jDAO.SelectBD(Pesquisa_tb.Text).Count == 1)
                        {
                            EditEquipeJogadorTecnico ec = new EditEquipeJogadorTecnico();
                            ec.Show();
                            ec.JogadorEditMode(Pesquisa_tb.Text);
                        }
                        else
                        { MessageBox.Show("Nome não encontrado!"); return; }
                        break;
                    case "Estádios":
                        Classes.EstadioDAO eDAO = new Classes.EstadioDAO();
                        if (eDAO.SelectBD(Pesquisa_tb.Text).Count == 1)
                        {
                            EditEstadio ec = new EditEstadio();
                            ec.Show();
                            ec.EstadioEditMode(Pesquisa_tb.Text);
                        }
                        else
                        { MessageBox.Show("Nome não encontrado!"); return; }
                        break;
                    case "Técnicos":
                        Classes.TecnicoDAO tDAO = new Classes.TecnicoDAO();
                        if (tDAO.SelectBD(Pesquisa_tb.Text).Count == 1)
                        {
                            EditEquipeJogadorTecnico ec = new EditEquipeJogadorTecnico();
                            ec.Show();
                            ec.TecnicoEditMode(Pesquisa_tb.Text);
                        }
                        else
                        { MessageBox.Show("Nome não encontrado!"); return; }
                        break;
                    case "Jogos":
                        MessageBox.Show("Você não tem permissão para alterar histórico de jogos!");
                        break;
                }
                Refresh();
                ControlarComponentes(FormStatus.Pesquisa);
                Pesquisa_tb.Clear();
            }
               
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && tipo_pesquisa_cb.Text != "Jogos")
            {
                Pesquisa_tb.Text = Convert.ToString(dataGridView1.SelectedCells[dataGridView1.Columns["nome"].Index].Value);
                Pesquisa_tb.Focus();
                ControlarComponentes(FormStatus.Edicao);
            }
           
        }

        private void newReg_bt_Click(object sender, EventArgs e)
        {
            EditEquipeJogadorTecnico ede = new EditEquipeJogadorTecnico();
            switch (tipo_pesquisa_cb.Text)
            {
                case "Campeonatos":
                    EditCampeonato edc = new EditCampeonato();
                    edc.Show();
                    break;
                case "Equipes":
                    ede.Show();
                    break;
                case "Jogadores":
                    ede.Show();
                    break;
                case "Estádios":
                    EditEstadio ee = new EditEstadio();
                    ee.Show();
                    break;
                case "Técnicos":
                    ede.Show();
                    break;
                case "Jogos":
                    Placar p = new Placar();
                    p.Show();
                    break;
            }
        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            switch (tipo_pesquisa_cb.Text)
            {
                case "Campeonatos":
                    Classes.CampeonatoDAO cDAO = new Classes.CampeonatoDAO();
                    if(cDAO.SelectBD(Pesquisa_tb.Text).Count == 1)
                    {
                        cDAO.DeleteBD(Pesquisa_tb.Text);
                        Pesquisa_tb.Clear();
                    }
                    else
                        { MessageBox.Show("Nome não encontrado!"); return; }
                    break;
                case "Equipes":
                    Classes.EquipeDAO eDAO = new Classes.EquipeDAO();
                    if (eDAO.SelectBD(Pesquisa_tb.Text).Count == 1)
                    {
                        eDAO.DeleteBD(Pesquisa_tb.Text);
                        Pesquisa_tb.Clear();
                    }
                    else
                    { MessageBox.Show("Nome não encontrado!"); return; }
                    break;
                case "Jogadores":
                    Classes.JogadorDAO jDAO = new Classes.JogadorDAO();
                    if (jDAO.SelectBD(Pesquisa_tb.Text).Count == 1)
                    {
                        jDAO.DeleteBD(Pesquisa_tb.Text);
                        Pesquisa_tb.Clear();
                    }
                    else
                    { MessageBox.Show("Nome não encontrado!"); return; }
                    break;
                case "Estádios":
                    Classes.EstadioDAO sDAO = new Classes.EstadioDAO();
                    if (sDAO.SelectBD(Pesquisa_tb.Text).Count == 1)
                    {
                        sDAO.DeleteBD(Pesquisa_tb.Text);
                        Pesquisa_tb.Clear();
                    }
                    else
                    { MessageBox.Show("Nome não encontrado!"); return; }
                    break;
                case "Técnicos":
                    Classes.TecnicoDAO tDAO = new Classes.TecnicoDAO();
                    if (tDAO.SelectBD(Pesquisa_tb.Text).Count == 1)
                    {
                        tDAO.DeleteBD(Pesquisa_tb.Text);
                        Pesquisa_tb.Clear();
                    }
                    else
                    { MessageBox.Show("Nome não encontrado!"); return; }
                    break;
                case "Jogos":
                    MessageBox.Show("Você não tem permissão para alterar histórico de jogos!");
                    break;
            }
            Refresh();
            ControlarComponentes(FormStatus.Pesquisa);
        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Registrar r = new Registrar();
            r.Show();
            r.OrganizadorEditMode(Login.userName);
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deletarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes.OrganizadorDAO oDAO = new Classes.OrganizadorDAO();
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

        private void Main_Menu_Organizador_Load(object sender, EventArgs e)
        {
            Classes.Organizadores or = new Classes.OrganizadorDAO().SelectBD(Login.userName)[0];
            NomeCompleto_lb.Text = or.Nome_completo;
            org_lb.Text = "Organização: " + or.Organização;
            id_lb.Text = "ID: " + Convert.ToString(or.Id);
            func_lb.Text = or.Função;

            List<Classes.Jogo> listjogo = new Classes.JogoDAO().SelectBD("");

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
