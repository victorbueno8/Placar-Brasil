namespace Placar_Brasil.Forms
{
    partial class EditCampeonato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCampeonato));
            this.nomeCampeonato_tb = new System.Windows.Forms.TextBox();
            this.Abrangencia_tb = new System.Windows.Forms.TextBox();
            this.descricao_tb = new System.Windows.Forms.TextBox();
            this.Confirma_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edit_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeCampeonato_tb
            // 
            this.nomeCampeonato_tb.Location = new System.Drawing.Point(37, 40);
            this.nomeCampeonato_tb.Name = "nomeCampeonato_tb";
            this.nomeCampeonato_tb.Size = new System.Drawing.Size(176, 20);
            this.nomeCampeonato_tb.TabIndex = 0;
            // 
            // Abrangencia_tb
            // 
            this.Abrangencia_tb.Location = new System.Drawing.Point(37, 99);
            this.Abrangencia_tb.Name = "Abrangencia_tb";
            this.Abrangencia_tb.Size = new System.Drawing.Size(176, 20);
            this.Abrangencia_tb.TabIndex = 1;
            // 
            // descricao_tb
            // 
            this.descricao_tb.Location = new System.Drawing.Point(37, 163);
            this.descricao_tb.Name = "descricao_tb";
            this.descricao_tb.Size = new System.Drawing.Size(176, 20);
            this.descricao_tb.TabIndex = 2;
            // 
            // Confirma_bt
            // 
            this.Confirma_bt.Location = new System.Drawing.Point(138, 223);
            this.Confirma_bt.Name = "Confirma_bt";
            this.Confirma_bt.Size = new System.Drawing.Size(75, 23);
            this.Confirma_bt.TabIndex = 3;
            this.Confirma_bt.Text = "Confirma";
            this.Confirma_bt.UseVisualStyleBackColor = true;
            this.Confirma_bt.Click += new System.EventHandler(this.Confirma_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Abrangência:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo:";
            // 
            // edit_bt
            // 
            this.edit_bt.Location = new System.Drawing.Point(37, 223);
            this.edit_bt.Name = "edit_bt";
            this.edit_bt.Size = new System.Drawing.Size(75, 23);
            this.edit_bt.TabIndex = 7;
            this.edit_bt.Text = "Editar";
            this.edit_bt.UseVisualStyleBackColor = true;
            this.edit_bt.Click += new System.EventHandler(this.edit_bt_Click);
            // 
            // EditCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(251, 278);
            this.Controls.Add(this.edit_bt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confirma_bt);
            this.Controls.Add(this.descricao_tb);
            this.Controls.Add(this.Abrangencia_tb);
            this.Controls.Add(this.nomeCampeonato_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCampeonato";
            this.Text = "Campeonato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeCampeonato_tb;
        private System.Windows.Forms.TextBox Abrangencia_tb;
        private System.Windows.Forms.TextBox descricao_tb;
        private System.Windows.Forms.Button Confirma_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button edit_bt;
    }
}