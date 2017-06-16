namespace Placar_Brasil.Forms
{
    partial class Main_Menu_Organizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu_Organizador));
            this.tipo_pesquisa_cb = new System.Windows.Forms.ComboBox();
            this.pesquisa_bt = new System.Windows.Forms.Button();
            this.Pesquisa_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_bt = new System.Windows.Forms.Button();
            this.newReg_bt = new System.Windows.Forms.Button();
            this.delete_bt = new System.Windows.Forms.Button();
            this.newgame_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.id_lb = new System.Windows.Forms.Label();
            this.org_lb = new System.Windows.Forms.Label();
            this.func_lb = new System.Windows.Forms.Label();
            this.NomeCompleto_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipo_pesquisa_cb
            // 
            this.tipo_pesquisa_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_pesquisa_cb.FormattingEnabled = true;
            this.tipo_pesquisa_cb.Location = new System.Drawing.Point(23, 149);
            this.tipo_pesquisa_cb.Name = "tipo_pesquisa_cb";
            this.tipo_pesquisa_cb.Size = new System.Drawing.Size(217, 21);
            this.tipo_pesquisa_cb.TabIndex = 10;
            this.tipo_pesquisa_cb.SelectedIndexChanged += new System.EventHandler(this.tipo_pesquisa_cb_SelectedIndexChanged);
            // 
            // pesquisa_bt
            // 
            this.pesquisa_bt.Location = new System.Drawing.Point(707, 30);
            this.pesquisa_bt.Name = "pesquisa_bt";
            this.pesquisa_bt.Size = new System.Drawing.Size(75, 23);
            this.pesquisa_bt.TabIndex = 9;
            this.pesquisa_bt.Text = "Pesquisar";
            this.pesquisa_bt.UseVisualStyleBackColor = true;
            this.pesquisa_bt.Click += new System.EventHandler(this.pesquisa_bt_Click);
            // 
            // Pesquisa_tb
            // 
            this.Pesquisa_tb.Location = new System.Drawing.Point(246, 149);
            this.Pesquisa_tb.Name = "Pesquisa_tb";
            this.Pesquisa_tb.Size = new System.Drawing.Size(469, 20);
            this.Pesquisa_tb.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(23, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(765, 326);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoJogoToolStripMenuItem,
            this.logOffToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // novoJogoToolStripMenuItem
            // 
            this.novoJogoToolStripMenuItem.Name = "novoJogoToolStripMenuItem";
            this.novoJogoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.novoJogoToolStripMenuItem.Text = "Novo Jogo";
            this.novoJogoToolStripMenuItem.Click += new System.EventHandler(this.novoJogoToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.logOffToolStripMenuItem.Text = "LogOff";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pesquisa_bt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 396);
            this.groupBox1.TabIndex = 11;
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
            // edit_bt
            // 
            this.edit_bt.Location = new System.Drawing.Point(807, 120);
            this.edit_bt.Name = "edit_bt";
            this.edit_bt.Size = new System.Drawing.Size(60, 65);
            this.edit_bt.TabIndex = 12;
            this.edit_bt.Text = "Editar";
            this.edit_bt.UseVisualStyleBackColor = true;
            this.edit_bt.Click += new System.EventHandler(this.edit_bt_Click);
            // 
            // newReg_bt
            // 
            this.newReg_bt.Location = new System.Drawing.Point(807, 191);
            this.newReg_bt.Name = "newReg_bt";
            this.newReg_bt.Size = new System.Drawing.Size(60, 65);
            this.newReg_bt.TabIndex = 13;
            this.newReg_bt.Text = "Novo";
            this.newReg_bt.UseVisualStyleBackColor = true;
            this.newReg_bt.Click += new System.EventHandler(this.newReg_bt_Click);
            // 
            // delete_bt
            // 
            this.delete_bt.Location = new System.Drawing.Point(807, 262);
            this.delete_bt.Name = "delete_bt";
            this.delete_bt.Size = new System.Drawing.Size(60, 67);
            this.delete_bt.TabIndex = 14;
            this.delete_bt.Text = "Deletar";
            this.delete_bt.UseVisualStyleBackColor = true;
            this.delete_bt.Click += new System.EventHandler(this.delete_bt_Click);
            // 
            // newgame_bt
            // 
            this.newgame_bt.Location = new System.Drawing.Point(808, 335);
            this.newgame_bt.Name = "newgame_bt";
            this.newgame_bt.Size = new System.Drawing.Size(59, 180);
            this.newgame_bt.TabIndex = 15;
            this.newgame_bt.Text = "Novo Jogo";
            this.newgame_bt.UseVisualStyleBackColor = true;
            this.newgame_bt.Click += new System.EventHandler(this.newgame_bt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(847, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Selecione linha para habilitar Edição e Exclusão     /      Clique em pesquisar p" +
    "ara Atualizar a Tabela    /    Selecione jogo e clique em novo para fazer um nov" +
    "o jogo ou Novo Jogo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.id_lb);
            this.groupBox2.Controls.Add(this.org_lb);
            this.groupBox2.Controls.Add(this.func_lb);
            this.groupBox2.Controls.Add(this.NomeCompleto_lb);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 87);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Organizador";
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
            // org_lb
            // 
            this.org_lb.AutoSize = true;
            this.org_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.org_lb.Location = new System.Drawing.Point(347, 20);
            this.org_lb.Name = "org_lb";
            this.org_lb.Size = new System.Drawing.Size(77, 15);
            this.org_lb.TabIndex = 8;
            this.org_lb.Text = "Organização";
            // 
            // func_lb
            // 
            this.func_lb.AutoSize = true;
            this.func_lb.Location = new System.Drawing.Point(12, 51);
            this.func_lb.Name = "func_lb";
            this.func_lb.Size = new System.Drawing.Size(58, 18);
            this.func_lb.TabIndex = 7;
            this.func_lb.Text = "Função";
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
            // Main_Menu_Organizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Placar_Brasil.Properties.Resources.futebol_de_campo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 546);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newgame_bt);
            this.Controls.Add(this.delete_bt);
            this.Controls.Add(this.newReg_bt);
            this.Controls.Add(this.edit_bt);
            this.Controls.Add(this.tipo_pesquisa_cb);
            this.Controls.Add(this.Pesquisa_tb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Menu_Organizador";
            this.Text = "Menu do Organizador";
            this.Load += new System.EventHandler(this.Main_Menu_Organizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tipo_pesquisa_cb;
        private System.Windows.Forms.Button pesquisa_bt;
        private System.Windows.Forms.TextBox Pesquisa_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCadastroToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem novoJogoToolStripMenuItem;
        private System.Windows.Forms.Button edit_bt;
        private System.Windows.Forms.Button newReg_bt;
        private System.Windows.Forms.Button delete_bt;
        private System.Windows.Forms.Button newgame_bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarCadastroToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Label org_lb;
        private System.Windows.Forms.Label func_lb;
        private System.Windows.Forms.Label NomeCompleto_lb;
    }
}