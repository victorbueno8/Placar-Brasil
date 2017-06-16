namespace Placar_Brasil.Forms
{
    partial class Placar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Placar));
            this.golCasa = new System.Windows.Forms.Button();
            this.golFora = new System.Windows.Forms.Button();
            this.Casa = new System.Windows.Forms.Label();
            this.Fora = new System.Windows.Forms.Label();
            this.Golscasa = new System.Windows.Forms.TextBox();
            this.Golsfora = new System.Windows.Forms.TextBox();
            this.finalizajogo_bt = new System.Windows.Forms.Button();
            this.time_casa = new System.Windows.Forms.ComboBox();
            this.time_fora = new System.Windows.Forms.ComboBox();
            this.iniciaJogo_bt = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Label();
            this.campeonato_cb = new System.Windows.Forms.ComboBox();
            this.Estadio_cb = new System.Windows.Forms.ComboBox();
            this.local_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // golCasa
            // 
            this.golCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golCasa.Location = new System.Drawing.Point(263, 180);
            this.golCasa.Name = "golCasa";
            this.golCasa.Size = new System.Drawing.Size(72, 59);
            this.golCasa.TabIndex = 0;
            this.golCasa.Text = "GOL";
            this.golCasa.UseVisualStyleBackColor = true;
            this.golCasa.Click += new System.EventHandler(this.golCasa_Click);
            // 
            // golFora
            // 
            this.golFora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golFora.Location = new System.Drawing.Point(386, 180);
            this.golFora.Name = "golFora";
            this.golFora.Size = new System.Drawing.Size(72, 59);
            this.golFora.TabIndex = 1;
            this.golFora.Text = "GOL";
            this.golFora.UseVisualStyleBackColor = true;
            this.golFora.Click += new System.EventHandler(this.golFora_Click);
            // 
            // Casa
            // 
            this.Casa.AutoSize = true;
            this.Casa.BackColor = System.Drawing.Color.OliveDrab;
            this.Casa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Casa.ForeColor = System.Drawing.Color.White;
            this.Casa.Location = new System.Drawing.Point(12, 9);
            this.Casa.Name = "Casa";
            this.Casa.Size = new System.Drawing.Size(52, 24);
            this.Casa.TabIndex = 2;
            this.Casa.Text = "Casa";
            // 
            // Fora
            // 
            this.Fora.AutoSize = true;
            this.Fora.BackColor = System.Drawing.Color.OliveDrab;
            this.Fora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fora.ForeColor = System.Drawing.Color.White;
            this.Fora.Location = new System.Drawing.Point(652, 9);
            this.Fora.Name = "Fora";
            this.Fora.Size = new System.Drawing.Size(49, 24);
            this.Fora.TabIndex = 3;
            this.Fora.Text = "Fora";
            // 
            // Golscasa
            // 
            this.Golscasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Golscasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Golscasa.Location = new System.Drawing.Point(64, 137);
            this.Golscasa.Name = "Golscasa";
            this.Golscasa.ReadOnly = true;
            this.Golscasa.Size = new System.Drawing.Size(127, 116);
            this.Golscasa.TabIndex = 4;
            this.Golscasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Golsfora
            // 
            this.Golsfora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Golsfora.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Golsfora.Location = new System.Drawing.Point(522, 137);
            this.Golsfora.Name = "Golsfora";
            this.Golsfora.ReadOnly = true;
            this.Golsfora.Size = new System.Drawing.Size(125, 116);
            this.Golsfora.TabIndex = 5;
            this.Golsfora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // finalizajogo_bt
            // 
            this.finalizajogo_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizajogo_bt.Location = new System.Drawing.Point(304, 311);
            this.finalizajogo_bt.Name = "finalizajogo_bt";
            this.finalizajogo_bt.Size = new System.Drawing.Size(117, 47);
            this.finalizajogo_bt.TabIndex = 8;
            this.finalizajogo_bt.Text = "Finalizar Jogo";
            this.finalizajogo_bt.UseVisualStyleBackColor = true;
            this.finalizajogo_bt.Click += new System.EventHandler(this.finalizajogo_Click);
            // 
            // time_casa
            // 
            this.time_casa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time_casa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_casa.FormattingEnabled = true;
            this.time_casa.Location = new System.Drawing.Point(39, 78);
            this.time_casa.Name = "time_casa";
            this.time_casa.Size = new System.Drawing.Size(296, 33);
            this.time_casa.TabIndex = 9;
            // 
            // time_fora
            // 
            this.time_fora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time_fora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_fora.FormattingEnabled = true;
            this.time_fora.Location = new System.Drawing.Point(385, 78);
            this.time_fora.Name = "time_fora";
            this.time_fora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.time_fora.Size = new System.Drawing.Size(296, 33);
            this.time_fora.TabIndex = 10;
            // 
            // iniciaJogo_bt
            // 
            this.iniciaJogo_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciaJogo_bt.Location = new System.Drawing.Point(304, 146);
            this.iniciaJogo_bt.Name = "iniciaJogo_bt";
            this.iniciaJogo_bt.Size = new System.Drawing.Size(117, 61);
            this.iniciaJogo_bt.TabIndex = 11;
            this.iniciaJogo_bt.Text = "Iniciar";
            this.iniciaJogo_bt.UseVisualStyleBackColor = true;
            this.iniciaJogo_bt.Click += new System.EventHandler(this.iniciaJogo_bt_Click);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(342, 188);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(38, 37);
            this.X.TabIndex = 12;
            this.X.Text = "X";
            this.X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campeonato_cb
            // 
            this.campeonato_cb.BackColor = System.Drawing.SystemColors.Window;
            this.campeonato_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campeonato_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campeonato_cb.FormattingEnabled = true;
            this.campeonato_cb.Location = new System.Drawing.Point(189, 12);
            this.campeonato_cb.Name = "campeonato_cb";
            this.campeonato_cb.Size = new System.Drawing.Size(351, 41);
            this.campeonato_cb.TabIndex = 13;
            // 
            // Estadio_cb
            // 
            this.Estadio_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Estadio_cb.FormattingEnabled = true;
            this.Estadio_cb.Location = new System.Drawing.Point(283, 263);
            this.Estadio_cb.Name = "Estadio_cb";
            this.Estadio_cb.Size = new System.Drawing.Size(158, 21);
            this.Estadio_cb.TabIndex = 14;
            // 
            // local_lb
            // 
            this.local_lb.AutoSize = true;
            this.local_lb.BackColor = System.Drawing.Color.Green;
            this.local_lb.ForeColor = System.Drawing.Color.White;
            this.local_lb.Location = new System.Drawing.Point(241, 266);
            this.local_lb.Name = "local_lb";
            this.local_lb.Size = new System.Drawing.Size(36, 13);
            this.local_lb.TabIndex = 15;
            this.local_lb.Text = "Local:";
            // 
            // Placar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Placar_Brasil.Properties.Resources.campo_futebol_placar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 392);
            this.Controls.Add(this.local_lb);
            this.Controls.Add(this.Estadio_cb);
            this.Controls.Add(this.campeonato_cb);
            this.Controls.Add(this.iniciaJogo_bt);
            this.Controls.Add(this.time_fora);
            this.Controls.Add(this.time_casa);
            this.Controls.Add(this.finalizajogo_bt);
            this.Controls.Add(this.Golsfora);
            this.Controls.Add(this.Golscasa);
            this.Controls.Add(this.Fora);
            this.Controls.Add(this.Casa);
            this.Controls.Add(this.golFora);
            this.Controls.Add(this.golCasa);
            this.Controls.Add(this.X);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Placar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Placar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button golCasa;
        private System.Windows.Forms.Button golFora;
        private System.Windows.Forms.Label Casa;
        private System.Windows.Forms.Label Fora;
        private System.Windows.Forms.TextBox Golscasa;
        private System.Windows.Forms.TextBox Golsfora;
        private System.Windows.Forms.Button finalizajogo_bt;
        private System.Windows.Forms.ComboBox time_casa;
        private System.Windows.Forms.ComboBox time_fora;
        private System.Windows.Forms.Button iniciaJogo_bt;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.ComboBox campeonato_cb;
        private System.Windows.Forms.ComboBox Estadio_cb;
        private System.Windows.Forms.Label local_lb;
    }
}