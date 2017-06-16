namespace Placar_Brasil.Forms
{
    partial class Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            this.registrar_bt = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.autentificação_lb = new System.Windows.Forms.Label();
            this.nome_tb = new System.Windows.Forms.TextBox();
            this.confsenha_tb = new System.Windows.Forms.TextBox();
            this.usuario_tb = new System.Windows.Forms.TextBox();
            this.senha_tb = new System.Windows.Forms.TextBox();
            this.Autentificacao_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.nome_completo_tb = new System.Windows.Forms.TextBox();
            this.namecomplet_lb = new System.Windows.Forms.Label();
            this.torcedor = new System.Windows.Forms.RadioButton();
            this.organizador = new System.Windows.Forms.RadioButton();
            this.cpf_label = new System.Windows.Forms.Label();
            this.cpf_tb = new System.Windows.Forms.TextBox();
            this.time_lb = new System.Windows.Forms.Label();
            this.organização_lb = new System.Windows.Forms.Label();
            this.organização_tb = new System.Windows.Forms.TextBox();
            this.função_lb = new System.Windows.Forms.Label();
            this.funcao_tb = new System.Windows.Forms.TextBox();
            this.time_tb = new System.Windows.Forms.ComboBox();
            this.edit_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrar_bt
            // 
            this.registrar_bt.Location = new System.Drawing.Point(486, 318);
            this.registrar_bt.Name = "registrar_bt";
            this.registrar_bt.Size = new System.Drawing.Size(75, 23);
            this.registrar_bt.TabIndex = 0;
            this.registrar_bt.Text = "Registrar";
            this.registrar_bt.UseVisualStyleBackColor = true;
            this.registrar_bt.Click += new System.EventHandler(this.registrar_bt_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(26, 13);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(38, 13);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Nome:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(26, 61);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(46, 13);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Usuario:";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(26, 109);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(41, 13);
            this.lb3.TabIndex = 3;
            this.lb3.Text = "Senha:";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(29, 160);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(85, 13);
            this.lb4.TabIndex = 4;
            this.lb4.Text = "Confirma Senha:";
            // 
            // autentificação_lb
            // 
            this.autentificação_lb.AutoSize = true;
            this.autentificação_lb.Location = new System.Drawing.Point(331, 163);
            this.autentificação_lb.Name = "autentificação_lb";
            this.autentificação_lb.Size = new System.Drawing.Size(196, 13);
            this.autentificação_lb.TabIndex = 5;
            this.autentificação_lb.Text = "Codigo de autentificação da autoridade:";
            // 
            // nome_tb
            // 
            this.nome_tb.Location = new System.Drawing.Point(29, 30);
            this.nome_tb.Name = "nome_tb";
            this.nome_tb.Size = new System.Drawing.Size(227, 20);
            this.nome_tb.TabIndex = 6;
            // 
            // confsenha_tb
            // 
            this.confsenha_tb.Location = new System.Drawing.Point(29, 179);
            this.confsenha_tb.Name = "confsenha_tb";
            this.confsenha_tb.Size = new System.Drawing.Size(227, 20);
            this.confsenha_tb.TabIndex = 7;
            // 
            // usuario_tb
            // 
            this.usuario_tb.Location = new System.Drawing.Point(29, 77);
            this.usuario_tb.Name = "usuario_tb";
            this.usuario_tb.Size = new System.Drawing.Size(227, 20);
            this.usuario_tb.TabIndex = 8;
            // 
            // senha_tb
            // 
            this.senha_tb.Location = new System.Drawing.Point(29, 125);
            this.senha_tb.Name = "senha_tb";
            this.senha_tb.Size = new System.Drawing.Size(227, 20);
            this.senha_tb.TabIndex = 9;
            // 
            // Autentificacao_tb
            // 
            this.Autentificacao_tb.Location = new System.Drawing.Point(334, 179);
            this.Autentificacao_tb.Name = "Autentificacao_tb";
            this.Autentificacao_tb.Size = new System.Drawing.Size(227, 20);
            this.Autentificacao_tb.TabIndex = 10;
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(334, 77);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(227, 20);
            this.email_tb.TabIndex = 11;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(339, 61);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(38, 13);
            this.email_label.TabIndex = 12;
            this.email_label.Text = "E-mail:";
            // 
            // nome_completo_tb
            // 
            this.nome_completo_tb.Location = new System.Drawing.Point(29, 226);
            this.nome_completo_tb.Name = "nome_completo_tb";
            this.nome_completo_tb.Size = new System.Drawing.Size(227, 20);
            this.nome_completo_tb.TabIndex = 13;
            // 
            // namecomplet_lb
            // 
            this.namecomplet_lb.AutoSize = true;
            this.namecomplet_lb.Location = new System.Drawing.Point(29, 210);
            this.namecomplet_lb.Name = "namecomplet_lb";
            this.namecomplet_lb.Size = new System.Drawing.Size(85, 13);
            this.namecomplet_lb.TabIndex = 14;
            this.namecomplet_lb.Text = "Nome Completo:";
            // 
            // torcedor
            // 
            this.torcedor.AutoSize = true;
            this.torcedor.Location = new System.Drawing.Point(58, 278);
            this.torcedor.Name = "torcedor";
            this.torcedor.Size = new System.Drawing.Size(68, 17);
            this.torcedor.TabIndex = 15;
            this.torcedor.TabStop = true;
            this.torcedor.Text = "Torcedor";
            this.torcedor.UseVisualStyleBackColor = true;
            this.torcedor.CheckedChanged += new System.EventHandler(this.torcedor_CheckedChanged);
            // 
            // organizador
            // 
            this.organizador.AutoSize = true;
            this.organizador.Location = new System.Drawing.Point(156, 278);
            this.organizador.Name = "organizador";
            this.organizador.Size = new System.Drawing.Size(82, 17);
            this.organizador.TabIndex = 16;
            this.organizador.TabStop = true;
            this.organizador.Text = "Organizador";
            this.organizador.UseVisualStyleBackColor = true;
            this.organizador.CheckedChanged += new System.EventHandler(this.organizador_CheckedChanged);
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.Location = new System.Drawing.Point(339, 14);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(30, 13);
            this.cpf_label.TabIndex = 18;
            this.cpf_label.Text = "CPF:";
            // 
            // cpf_tb
            // 
            this.cpf_tb.Location = new System.Drawing.Point(334, 30);
            this.cpf_tb.Name = "cpf_tb";
            this.cpf_tb.Size = new System.Drawing.Size(227, 20);
            this.cpf_tb.TabIndex = 17;
            // 
            // time_lb
            // 
            this.time_lb.AutoSize = true;
            this.time_lb.Location = new System.Drawing.Point(339, 109);
            this.time_lb.Name = "time_lb";
            this.time_lb.Size = new System.Drawing.Size(75, 13);
            this.time_lb.TabIndex = 20;
            this.time_lb.Text = "Nome do time:";
            // 
            // organização_lb
            // 
            this.organização_lb.AutoSize = true;
            this.organização_lb.Location = new System.Drawing.Point(339, 212);
            this.organização_lb.Name = "organização_lb";
            this.organização_lb.Size = new System.Drawing.Size(70, 13);
            this.organização_lb.TabIndex = 22;
            this.organização_lb.Text = "Organização:";
            // 
            // organização_tb
            // 
            this.organização_tb.Location = new System.Drawing.Point(334, 228);
            this.organização_tb.Name = "organização_tb";
            this.organização_tb.Size = new System.Drawing.Size(227, 20);
            this.organização_tb.TabIndex = 21;
            // 
            // função_lb
            // 
            this.função_lb.AutoSize = true;
            this.função_lb.Location = new System.Drawing.Point(339, 262);
            this.função_lb.Name = "função_lb";
            this.função_lb.Size = new System.Drawing.Size(124, 13);
            this.função_lb.TabIndex = 24;
            this.função_lb.Text = "Função na Organização:";
            // 
            // funcao_tb
            // 
            this.funcao_tb.Location = new System.Drawing.Point(334, 278);
            this.funcao_tb.Name = "funcao_tb";
            this.funcao_tb.Size = new System.Drawing.Size(227, 20);
            this.funcao_tb.TabIndex = 23;
            // 
            // time_tb
            // 
            this.time_tb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time_tb.FormattingEnabled = true;
            this.time_tb.Location = new System.Drawing.Point(334, 125);
            this.time_tb.Name = "time_tb";
            this.time_tb.Size = new System.Drawing.Size(227, 21);
            this.time_tb.TabIndex = 25;
            // 
            // edit_bt
            // 
            this.edit_bt.Location = new System.Drawing.Point(388, 318);
            this.edit_bt.Name = "edit_bt";
            this.edit_bt.Size = new System.Drawing.Size(75, 23);
            this.edit_bt.TabIndex = 26;
            this.edit_bt.Text = "Editar";
            this.edit_bt.UseVisualStyleBackColor = true;
            this.edit_bt.Click += new System.EventHandler(this.edit_bt_Click);
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 359);
            this.Controls.Add(this.edit_bt);
            this.Controls.Add(this.time_tb);
            this.Controls.Add(this.função_lb);
            this.Controls.Add(this.funcao_tb);
            this.Controls.Add(this.organização_lb);
            this.Controls.Add(this.organização_tb);
            this.Controls.Add(this.time_lb);
            this.Controls.Add(this.cpf_label);
            this.Controls.Add(this.cpf_tb);
            this.Controls.Add(this.organizador);
            this.Controls.Add(this.torcedor);
            this.Controls.Add(this.namecomplet_lb);
            this.Controls.Add(this.nome_completo_tb);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.Autentificacao_tb);
            this.Controls.Add(this.senha_tb);
            this.Controls.Add(this.usuario_tb);
            this.Controls.Add(this.confsenha_tb);
            this.Controls.Add(this.nome_tb);
            this.Controls.Add(this.autentificação_lb);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.registrar_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrar_bt;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label autentificação_lb;
        private System.Windows.Forms.TextBox nome_tb;
        private System.Windows.Forms.TextBox confsenha_tb;
        private System.Windows.Forms.TextBox usuario_tb;
        private System.Windows.Forms.TextBox senha_tb;
        private System.Windows.Forms.TextBox Autentificacao_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox nome_completo_tb;
        private System.Windows.Forms.Label namecomplet_lb;
        private System.Windows.Forms.RadioButton torcedor;
        private System.Windows.Forms.RadioButton organizador;
        private System.Windows.Forms.Label cpf_label;
        private System.Windows.Forms.TextBox cpf_tb;
        private System.Windows.Forms.Label time_lb;
        private System.Windows.Forms.Label organização_lb;
        private System.Windows.Forms.TextBox organização_tb;
        private System.Windows.Forms.Label função_lb;
        private System.Windows.Forms.TextBox funcao_tb;
        private System.Windows.Forms.ComboBox time_tb;
        private System.Windows.Forms.Button edit_bt;
    }
}