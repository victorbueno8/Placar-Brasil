namespace Placar_Brasil.Forms
{
    partial class EditEquipeJogadorTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEquipeJogadorTecnico));
            this.label1 = new System.Windows.Forms.Label();
            this.Doc_lb = new System.Windows.Forms.Label();
            this.docidentidade_tb = new System.Windows.Forms.TextBox();
            this.nomejogador_lb = new System.Windows.Forms.Label();
            this.nome_tb = new System.Windows.Forms.TextBox();
            this.cidorigem_lb = new System.Windows.Forms.Label();
            this.cidade_origem_tb = new System.Windows.Forms.TextBox();
            this.apelido_lb = new System.Windows.Forms.Label();
            this.apelido_tb = new System.Windows.Forms.TextBox();
            this.posicao_tb = new System.Windows.Forms.TextBox();
            this.posicao_lb = new System.Windows.Forms.Label();
            this.jogador_checkbutton = new System.Windows.Forms.RadioButton();
            this.tecnico_checkedbutton = new System.Windows.Forms.RadioButton();
            this.anosexp_tb = new System.Windows.Forms.TextBox();
            this.anoexp_lb = new System.Windows.Forms.Label();
            this.Confirma = new System.Windows.Forms.Button();
            this.equipeNome_tb = new System.Windows.Forms.ComboBox();
            this.edit_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Equipe:";
            // 
            // Doc_lb
            // 
            this.Doc_lb.AutoSize = true;
            this.Doc_lb.Location = new System.Drawing.Point(40, 128);
            this.Doc_lb.Name = "Doc_lb";
            this.Doc_lb.Size = new System.Drawing.Size(133, 13);
            this.Doc_lb.TabIndex = 2;
            this.Doc_lb.Text = "Documento de Identidade:";
            // 
            // docidentidade_tb
            // 
            this.docidentidade_tb.Location = new System.Drawing.Point(40, 144);
            this.docidentidade_tb.Name = "docidentidade_tb";
            this.docidentidade_tb.Size = new System.Drawing.Size(154, 20);
            this.docidentidade_tb.TabIndex = 3;
            // 
            // nomejogador_lb
            // 
            this.nomejogador_lb.AutoSize = true;
            this.nomejogador_lb.Location = new System.Drawing.Point(40, 89);
            this.nomejogador_lb.Name = "nomejogador_lb";
            this.nomejogador_lb.Size = new System.Drawing.Size(85, 13);
            this.nomejogador_lb.TabIndex = 4;
            this.nomejogador_lb.Text = "Nome Completo:";
            // 
            // nome_tb
            // 
            this.nome_tb.Location = new System.Drawing.Point(40, 105);
            this.nome_tb.Name = "nome_tb";
            this.nome_tb.Size = new System.Drawing.Size(241, 20);
            this.nome_tb.TabIndex = 5;
            // 
            // cidorigem_lb
            // 
            this.cidorigem_lb.AutoSize = true;
            this.cidorigem_lb.Location = new System.Drawing.Point(40, 167);
            this.cidorigem_lb.Name = "cidorigem_lb";
            this.cidorigem_lb.Size = new System.Drawing.Size(94, 13);
            this.cidorigem_lb.TabIndex = 6;
            this.cidorigem_lb.Text = "Cidade de Origem:";
            // 
            // cidade_origem_tb
            // 
            this.cidade_origem_tb.Location = new System.Drawing.Point(40, 183);
            this.cidade_origem_tb.Name = "cidade_origem_tb";
            this.cidade_origem_tb.Size = new System.Drawing.Size(180, 20);
            this.cidade_origem_tb.TabIndex = 7;
            // 
            // apelido_lb
            // 
            this.apelido_lb.AutoSize = true;
            this.apelido_lb.Location = new System.Drawing.Point(43, 210);
            this.apelido_lb.Name = "apelido_lb";
            this.apelido_lb.Size = new System.Drawing.Size(45, 13);
            this.apelido_lb.TabIndex = 8;
            this.apelido_lb.Text = "Apelido:";
            // 
            // apelido_tb
            // 
            this.apelido_tb.Location = new System.Drawing.Point(40, 226);
            this.apelido_tb.Name = "apelido_tb";
            this.apelido_tb.Size = new System.Drawing.Size(180, 20);
            this.apelido_tb.TabIndex = 9;
            // 
            // posicao_tb
            // 
            this.posicao_tb.Location = new System.Drawing.Point(40, 268);
            this.posicao_tb.Name = "posicao_tb";
            this.posicao_tb.Size = new System.Drawing.Size(100, 20);
            this.posicao_tb.TabIndex = 10;
            // 
            // posicao_lb
            // 
            this.posicao_lb.AutoSize = true;
            this.posicao_lb.Location = new System.Drawing.Point(43, 252);
            this.posicao_lb.Name = "posicao_lb";
            this.posicao_lb.Size = new System.Drawing.Size(48, 13);
            this.posicao_lb.TabIndex = 11;
            this.posicao_lb.Text = "Posição:";
            // 
            // jogador_checkbutton
            // 
            this.jogador_checkbutton.AutoSize = true;
            this.jogador_checkbutton.Location = new System.Drawing.Point(40, 69);
            this.jogador_checkbutton.Name = "jogador_checkbutton";
            this.jogador_checkbutton.Size = new System.Drawing.Size(63, 17);
            this.jogador_checkbutton.TabIndex = 12;
            this.jogador_checkbutton.Text = "Jogador";
            this.jogador_checkbutton.UseVisualStyleBackColor = true;
            this.jogador_checkbutton.CheckedChanged += new System.EventHandler(this.jogador_checkbutton_CheckedChanged);
            // 
            // tecnico_checkedbutton
            // 
            this.tecnico_checkedbutton.AutoSize = true;
            this.tecnico_checkedbutton.Location = new System.Drawing.Point(109, 69);
            this.tecnico_checkedbutton.Name = "tecnico_checkedbutton";
            this.tecnico_checkedbutton.Size = new System.Drawing.Size(67, 17);
            this.tecnico_checkedbutton.TabIndex = 13;
            this.tecnico_checkedbutton.Text = "Técnico:";
            this.tecnico_checkedbutton.UseVisualStyleBackColor = true;
            this.tecnico_checkedbutton.CheckedChanged += new System.EventHandler(this.tecnico_checkedbutton_CheckedChanged);
            // 
            // anosexp_tb
            // 
            this.anosexp_tb.Location = new System.Drawing.Point(36, 226);
            this.anosexp_tb.Name = "anosexp_tb";
            this.anosexp_tb.Size = new System.Drawing.Size(79, 20);
            this.anosexp_tb.TabIndex = 14;
            // 
            // anoexp_lb
            // 
            this.anoexp_lb.AutoSize = true;
            this.anoexp_lb.Location = new System.Drawing.Point(40, 210);
            this.anoexp_lb.Name = "anoexp_lb";
            this.anoexp_lb.Size = new System.Drawing.Size(107, 13);
            this.anoexp_lb.TabIndex = 15;
            this.anoexp_lb.Text = "Anos de Experiência:";
            // 
            // Confirma
            // 
            this.Confirma.Location = new System.Drawing.Point(40, 313);
            this.Confirma.Name = "Confirma";
            this.Confirma.Size = new System.Drawing.Size(75, 23);
            this.Confirma.TabIndex = 16;
            this.Confirma.Text = "Confirma";
            this.Confirma.UseVisualStyleBackColor = true;
            this.Confirma.Click += new System.EventHandler(this.Confirma_Click);
            // 
            // equipeNome_tb
            // 
            this.equipeNome_tb.FormattingEnabled = true;
            this.equipeNome_tb.Location = new System.Drawing.Point(40, 29);
            this.equipeNome_tb.Name = "equipeNome_tb";
            this.equipeNome_tb.Size = new System.Drawing.Size(241, 21);
            this.equipeNome_tb.TabIndex = 17;
            // 
            // edit_bt
            // 
            this.edit_bt.Location = new System.Drawing.Point(121, 313);
            this.edit_bt.Name = "edit_bt";
            this.edit_bt.Size = new System.Drawing.Size(75, 23);
            this.edit_bt.TabIndex = 18;
            this.edit_bt.Text = "Editar";
            this.edit_bt.UseVisualStyleBackColor = true;
            this.edit_bt.Click += new System.EventHandler(this.edit_bt_Click);
            // 
            // EditEquipeJogadorTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(314, 357);
            this.Controls.Add(this.edit_bt);
            this.Controls.Add(this.equipeNome_tb);
            this.Controls.Add(this.Confirma);
            this.Controls.Add(this.anoexp_lb);
            this.Controls.Add(this.anosexp_tb);
            this.Controls.Add(this.tecnico_checkedbutton);
            this.Controls.Add(this.jogador_checkbutton);
            this.Controls.Add(this.posicao_lb);
            this.Controls.Add(this.posicao_tb);
            this.Controls.Add(this.apelido_tb);
            this.Controls.Add(this.apelido_lb);
            this.Controls.Add(this.cidade_origem_tb);
            this.Controls.Add(this.cidorigem_lb);
            this.Controls.Add(this.nome_tb);
            this.Controls.Add(this.nomejogador_lb);
            this.Controls.Add(this.docidentidade_tb);
            this.Controls.Add(this.Doc_lb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditEquipeJogadorTecnico";
            this.Text = "Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Doc_lb;
        private System.Windows.Forms.TextBox docidentidade_tb;
        private System.Windows.Forms.Label nomejogador_lb;
        private System.Windows.Forms.TextBox nome_tb;
        private System.Windows.Forms.Label cidorigem_lb;
        private System.Windows.Forms.TextBox cidade_origem_tb;
        private System.Windows.Forms.Label apelido_lb;
        private System.Windows.Forms.TextBox apelido_tb;
        private System.Windows.Forms.TextBox posicao_tb;
        private System.Windows.Forms.Label posicao_lb;
        private System.Windows.Forms.RadioButton jogador_checkbutton;
        private System.Windows.Forms.RadioButton tecnico_checkedbutton;
        private System.Windows.Forms.TextBox anosexp_tb;
        private System.Windows.Forms.Label anoexp_lb;
        private System.Windows.Forms.Button Confirma;
        private System.Windows.Forms.ComboBox equipeNome_tb;
        private System.Windows.Forms.Button edit_bt;
    }
}