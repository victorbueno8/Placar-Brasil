namespace Placar_Brasil
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginEnter = new System.Windows.Forms.Button();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.torcedor_rb = new System.Windows.Forms.RadioButton();
            this.organizador_rb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // LoginEnter
            // 
            this.LoginEnter.Location = new System.Drawing.Point(321, 315);
            this.LoginEnter.Name = "LoginEnter";
            this.LoginEnter.Size = new System.Drawing.Size(96, 26);
            this.LoginEnter.TabIndex = 0;
            this.LoginEnter.Text = "Entrar";
            this.LoginEnter.UseVisualStyleBackColor = true;
            this.LoginEnter.Click += new System.EventHandler(this.LoginEnter_Click);
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(318, 198);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(230, 20);
            this.tb_usuario.TabIndex = 1;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(318, 247);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(230, 20);
            this.tb_senha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(318, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(318, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel1.Location = new System.Drawing.Point(468, 322);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Registrar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // torcedor_rb
            // 
            this.torcedor_rb.AutoSize = true;
            this.torcedor_rb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.torcedor_rb.Location = new System.Drawing.Point(318, 273);
            this.torcedor_rb.Name = "torcedor_rb";
            this.torcedor_rb.Size = new System.Drawing.Size(68, 17);
            this.torcedor_rb.TabIndex = 6;
            this.torcedor_rb.TabStop = true;
            this.torcedor_rb.Text = "Torcedor";
            this.torcedor_rb.UseVisualStyleBackColor = false;
            this.torcedor_rb.CheckedChanged += new System.EventHandler(this.torcedor_rb_CheckedChanged);
            // 
            // organizador_rb
            // 
            this.organizador_rb.AutoSize = true;
            this.organizador_rb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.organizador_rb.Location = new System.Drawing.Point(392, 273);
            this.organizador_rb.Name = "organizador_rb";
            this.organizador_rb.Size = new System.Drawing.Size(82, 17);
            this.organizador_rb.TabIndex = 7;
            this.organizador_rb.TabStop = true;
            this.organizador_rb.Text = "Organizador";
            this.organizador_rb.UseVisualStyleBackColor = false;
            this.organizador_rb.CheckedChanged += new System.EventHandler(this.organizador_rb_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(277, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 207);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign In";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Placar_Brasil.Properties.Resources.esporte_campo_de_futebol_Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 454);
            this.Controls.Add(this.organizador_rb);
            this.Controls.Add(this.torcedor_rb);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.LoginEnter);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Placar Brasil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginEnter;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton torcedor_rb;
        private System.Windows.Forms.RadioButton organizador_rb;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}