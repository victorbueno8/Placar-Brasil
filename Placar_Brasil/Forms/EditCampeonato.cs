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
    public partial class EditCampeonato : Form
    {
        enum FormStatus { Create, Edit}

        public string Cnome;

        public EditCampeonato()
        {
            InitializeComponent();
            ControlarComponentes(FormStatus.Create);
        }

        private void ControlarComponentes(FormStatus status)
        {
            Confirma_bt.Visible = status == FormStatus.Create ? true : false;
            edit_bt.Visible = status == FormStatus.Edit ? true : false;
        }

        private void Confirma_bt_Click(object sender, EventArgs e)
        {
            if(nomeCampeonato_tb.Text == ""|| Abrangencia_tb.Text==""||descricao_tb.Text=="")
            {
                MessageBox.Show("Preencha todos Campos!");
                return;
            }
            else
            {
                Classes.CampeonatoDAO cDAO = new Classes.CampeonatoDAO();
                Classes.Campeonato c = new Classes.Campeonato(Banco_de_Dados.AutoIncrementaId("Campeonato", "id"),nomeCampeonato_tb.Text,Abrangencia_tb.Text,descricao_tb.Text);

                cDAO.InsertBD(c);
                Close();
            }
        }

        public void CampeonatoEditMode(string nome)
        {
            Classes.Campeonato c = new Classes.CampeonatoDAO().SelectBD(nome)[0];
            this.Cnome = c.Nome;
            nomeCampeonato_tb.Text = c.Nome;
            Abrangencia_tb.Text = c.Abrangencia;
            descricao_tb.Text = c.Descricao;
            ControlarComponentes(FormStatus.Edit);
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
            if (nomeCampeonato_tb.Text == "" || Abrangencia_tb.Text == "" || descricao_tb.Text == "")
            {
                MessageBox.Show("Preencha todos Campos!");
                return;
            }
            else
            {
                Classes.CampeonatoDAO cDAO = new Classes.CampeonatoDAO();
                Classes.Campeonato c = new Classes.Campeonato(cDAO.SelectBD(Cnome)[0].Id, nomeCampeonato_tb.Text, Abrangencia_tb.Text, descricao_tb.Text);
                cDAO.UpdateBD(cDAO.SelectBD(Cnome)[0].Nome, c);
                Close();
            }
        }
    }
}
