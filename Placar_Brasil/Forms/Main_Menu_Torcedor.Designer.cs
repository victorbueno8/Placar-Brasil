namespace Placar_Brasil.Forms
{
    partial class Main_Menu_Torcedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu_Torcedor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pesquisa_tb = new System.Windows.Forms.TextBox();
            this.pesquisa_bt = new System.Windows.Forms.Button();
            this.tipo_pesquisa_cb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeCompleto_lb = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TimeTorce_lb = new System.Windows.Forms.Label();
            this.email_lb = new System.Windows.Forms.Label();
            this.id_lb = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOffToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.logOffToolStripMenuItem.Text = "LogOff";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCadastroToolStripMenuItem,
            this.deletarCadastroToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // novoCadastroToolStripMenuItem
            // 
            this.novoCadastroToolStripMenuItem.Name = "novoCadastroToolStripMenuItem";
            this.novoCadastroToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.novoCadastroToolStripMenuItem.Text = "Atualizar Cadastro";
            this.novoCadastroToolStripMenuItem.Click += new System.EventHandler(this.novoCadastroToolStripMenuItem_Click);
            // 
            // deletarCadastroToolStripMenuItem
            // 
            this.deletarCadastroToolStripMenuItem.Name = "deletarCadastroToolStripMenuItem";
            this.deletarCadastroToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.deletarCadastroToolStripMenuItem.Text = "Deletar Cadastro";
            this.deletarCadastroToolStripMenuItem.Click += new System.EventHandler(this.deletarCadastroToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(765, 326);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Pesquisa_tb
            // 
            this.Pesquisa_tb.Location = new System.Drawing.Point(236, 36);
            this.Pesquisa_tb.Name = "Pesquisa_tb";
            this.Pesquisa_tb.Size = new System.Drawing.Size(461, 20);
            this.Pesquisa_tb.TabIndex = 2;
            // 
            // pesquisa_bt
            // 
            this.pesquisa_bt.Location = new System.Drawing.Point(702, 34);
            this.pesquisa_bt.Name = "pesquisa_bt";
            this.pesquisa_bt.Size = new System.Drawing.Size(75, 23);
            this.pesquisa_bt.TabIndex = 3;
            this.pesquisa_bt.Text = "Pesquisar";
            this.pesquisa_bt.UseVisualStyleBackColor = true;
            this.pesquisa_bt.Click += new System.EventHandler(this.pesquisa_bt_Click);
            // 
            // tipo_pesquisa_cb
            // 
            this.tipo_pesquisa_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_pesquisa_cb.FormattingEnabled = true;
            this.tipo_pesquisa_cb.Location = new System.Drawing.Point(12, 36);
            this.tipo_pesquisa_cb.Name = "tipo_pesquisa_cb";
            this.tipo_pesquisa_cb.Size = new System.Drawing.Size(217, 21);
            this.tipo_pesquisa_cb.TabIndex = 4;
            this.tipo_pesquisa_cb.SelectedIndexChanged += new System.EventHandler(this.tipo_pesquisa_cb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.pesquisa_bt);
            this.groupBox1.Controls.Add(this.tipo_pesquisa_cb);
            this.groupBox1.Controls.Add(this.Pesquisa_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 401);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palavra-chave:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro:";
            // 
            // NomeCompleto_lb
            // 
            this.NomeCompleto_lb.AutoSize = true;
            this.NomeCompleto_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeCompleto_lb.Location = new System.Drawing.Point(11, 20);
            this.NomeCompleto_lb.Name = "NomeCompleto_lb";
            this.NomeCompleto_lb.Size = new System.Drawing.Size(138, 20);
            this.NomeCompleto_lb.TabIndex = 6;
            this.NomeCompleto_lb.Text = "Nome_completo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.id_lb);
            this.groupBox2.Controls.Add(this.email_lb);
            this.groupBox2.Controls.Add(this.TimeTorce_lb);
            this.groupBox2.Controls.Add(this.NomeCompleto_lb);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 87);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Torcedor";
            // 
            // TimeTorce_lb
            // 
            this.TimeTorce_lb.AutoSize = true;
            this.TimeTorce_lb.Location = new System.Drawing.Point(12, 51);
            this.TimeTorce_lb.Name = "TimeTorce_lb";
            this.TimeTorce_lb.Size = new System.Drawing.Size(41, 18);
            this.TimeTorce_lb.TabIndex = 7;
            this.TimeTorce_lb.Text = "Time";
            // 
            // email_lb
            // 
            this.email_lb.AutoSize = true;
            this.email_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lb.Location = new System.Drawing.Point(347, 20);
            this.email_lb.Name = "email_lb";
            this.email_lb.Size = new System.Drawing.Size(39, 15);
            this.email_lb.TabIndex = 8;
            this.email_lb.Text = "Email";
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.Location = new System.Drawing.Point(656, 20);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(19, 15);
            this.id_lb.TabIndex = 9;
            this.id_lb.Text = "ID";
            // 
            // Main_Menu_Torcedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Placar_Brasil.Properties.Resources.futebol_de_campo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 542);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main_Menu_Torcedor";
            this.Text = "Menu do Torcedor";
            this.Load += new System.EventHandler(this.Main_Menu_Torcedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCadastroToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.TextBox Pesquisa_tb;
        private System.Windows.Forms.Button pesquisa_bt;
        private System.Windows.Forms.ComboBox tipo_pesquisa_cb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem deletarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.Label NomeCompleto_lb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TimeTorce_lb;
        private System.Windows.Forms.Label email_lb;
        private System.Windows.Forms.Label id_lb;
    }
}