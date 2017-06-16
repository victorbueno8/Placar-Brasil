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
    public partial class EditEstadio : Form
    {
        enum FormStatus { Create, Edit }
        
        public string Cnome; //nome de procura antigo

        public EditEstadio()
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
            if(nomeEstadio_tb.Text==""||cidadeestadio_tb.Text==""||EstadoEstadio_tb.Text=="")
            {
                MessageBox.Show("Preencha todos Campos");
                return;
            }
            else
            {
                Classes.EstadioDAO eDAO = new Classes.EstadioDAO();
                Classes.Estadio estadio = new Classes.Estadio(Banco_de_Dados.AutoIncrementaId("Estadio","id"),nomeEstadio_tb.Text,cidadeestadio_tb.Text,EstadoEstadio_tb.Text);
                eDAO.InsertBD(estadio);
                Close();
            }
        }

        public void EstadioEditMode(string nome)
        {
            Classes.Estadio c = new Classes.EstadioDAO().SelectBD(nome)[0];
            this.Cnome = c.Nome;
            nomeEstadio_tb.Text = c.Nome;
            cidadeestadio_tb.Text = c.Cidade;
            EstadoEstadio_tb.Text = c.Estado;
            ControlarComponentes(FormStatus.Edit);
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
            if (nomeEstadio_tb.Text == "" || cidadeestadio_tb.Text == "" || EstadoEstadio_tb.Text == "")
            {
                MessageBox.Show("Preencha todos Campos!");
                return;
            }
            else
            {
                Classes.EstadioDAO cDAO = new Classes.EstadioDAO();
                Classes.Estadio c = new Classes.Estadio(cDAO.SelectBD(Cnome)[0].Id, nomeEstadio_tb.Text, cidadeestadio_tb.Text, EstadoEstadio_tb.Text);
                cDAO.UpdateBD(cDAO.SelectBD(Cnome)[0].Nome, c);
                Close();
            }
        }
    }
}
