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
    public partial class SplashWindow : Form
    {
        public SplashWindow()
        {
            InitializeComponent();
        }

        private void AtualizarProgresso(string text, int value)
        {
            Progresso_lb.Text = text;
            progressBar1.Value += value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                abrir();
                return;
            }
            AtualizarProgresso("Juiz começa a partida...", 20);
        }
        

        private void SplashWindow_Activated(object sender, EventArgs e)
        {
            AtualizarProgresso("Verificando dados em campo...", 20);
            Banco_de_Dados.TestarBD();
            AtualizarProgresso("Todos times já em Campo...", 20);
            timer1.Start();
        }

        public void abrir()
        {
            this.timer1.Enabled = false;
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
            Close();
        }
    }
}
