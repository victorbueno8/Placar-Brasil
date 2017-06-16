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
    public partial class Placar : Form
    {
        enum FormStatus{ criaJogo,  ComeçaJogo}

        public Placar()
        {
            InitializeComponent();
            Golscasa.Text = "0";
            Golsfora.Text = "0";
            ControlarComponentes(FormStatus.criaJogo);
            time_casa.DataSource = (new Classes.EquipeDAO()).SelectBD("");
            time_casa.DisplayMember = "nome";
            time_casa.SelectedIndex = -1;
            time_fora.DataSource = (new Classes.EquipeDAO()).SelectBD("");
            time_fora.DisplayMember = "nome";
            time_fora.SelectedIndex = -1;
            campeonato_cb.DataSource = (new Classes.CampeonatoDAO()).SelectBD("");
            campeonato_cb.DisplayMember = "nome";
            campeonato_cb.SelectedIndex = -1;
            Estadio_cb.DataSource = (new Classes.EstadioDAO()).SelectBD("");
            Estadio_cb.DisplayMember = "nome";
            Estadio_cb.SelectedIndex = -1;
        }

        private void ControlarComponentes(FormStatus status)
        {
            campeonato_cb.Enabled = status == FormStatus.criaJogo ? true : false;
            Estadio_cb.Enabled = status == FormStatus.criaJogo ? true : false;
            time_casa.Enabled = status == FormStatus.criaJogo ? true : false;
            time_fora.Enabled = status == FormStatus.criaJogo ? true : false;
            iniciaJogo_bt.Visible = status == FormStatus.criaJogo ? true : false;

            finalizajogo_bt.Enabled = status == FormStatus.ComeçaJogo ? true : false;
            golCasa.Enabled = status == FormStatus.ComeçaJogo ? true : false;
            golFora.Enabled = status == FormStatus.ComeçaJogo ? true : false;
            Golscasa.Enabled = status == FormStatus.ComeçaJogo ? true : false;
            Golsfora.Enabled = status == FormStatus.ComeçaJogo ? true : false;
        }
        
        
        private void golCasa_Click(object sender, EventArgs e)
        {
            int gols;
            gols = int.Parse(Golscasa.Text)+1;
            Golscasa.Text = Convert.ToString(gols);
        }

        private void golFora_Click(object sender, EventArgs e)
        {
            int gols;
            gols = int.Parse(Golsfora.Text) + 1;
            Golsfora.Text = Convert.ToString(gols);
        }

        private void finalizajogo_Click(object sender, EventArgs e)
        {
            Classes.JogoDAO jDAO = new Classes.JogoDAO();
            
            Classes.Jogo j = new Classes.Jogo(Banco_de_Dados.AutoIncrementaId("Jogo","id"),new Classes.EquipeDAO().SelectBD(time_casa.Text)[0],Convert.ToInt16(Golscasa.Text),new Classes.EquipeDAO().SelectBD(time_fora.Text)[0],Convert.ToInt16(Golsfora.Text),new Classes.EstadioDAO().SelectBD(Estadio_cb.Text)[0],new Classes.CampeonatoDAO().SelectBD(campeonato_cb.Text)[0],new Classes.OrganizadorDAO().SelectBD(Login.userName)[0]);
            jDAO.InsertBD(j);
            Close();
        }

        private void iniciaJogo_bt_Click(object sender, EventArgs e)
        {
            if(time_casa.Text != "" && time_fora.Text != "" && campeonato_cb.Text != "" && Estadio_cb.Text != "")
            {
                ControlarComponentes(FormStatus.ComeçaJogo);
            }
            else
            {
                MessageBox.Show("Preencha todos os dados para começar a partida!");
                return;
            }
        }
        
    }
}
