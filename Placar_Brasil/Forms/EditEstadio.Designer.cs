namespace Placar_Brasil.Forms
{
    partial class EditEstadio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEstadio));
            this.nomeEstadio_tb = new System.Windows.Forms.TextBox();
            this.cidadeestadio_tb = new System.Windows.Forms.TextBox();
            this.EstadoEstadio_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Confirma_bt = new System.Windows.Forms.Button();
            this.edit_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeEstadio_tb
            // 
            this.nomeEstadio_tb.Location = new System.Drawing.Point(28, 45);
            this.nomeEstadio_tb.Name = "nomeEstadio_tb";
            this.nomeEstadio_tb.Size = new System.Drawing.Size(185, 20);
            this.nomeEstadio_tb.TabIndex = 0;
            // 
            // cidadeestadio_tb
            // 
            this.cidadeestadio_tb.Location = new System.Drawing.Point(28, 100);
            this.cidadeestadio_tb.Name = "cidadeestadio_tb";
            this.cidadeestadio_tb.Size = new System.Drawing.Size(185, 20);
            this.cidadeestadio_tb.TabIndex = 1;
            // 
            // EstadoEstadio_tb
            // 
            this.EstadoEstadio_tb.Location = new System.Drawing.Point(28, 153);
            this.EstadoEstadio_tb.Name = "EstadoEstadio_tb";
            this.EstadoEstadio_tb.Size = new System.Drawing.Size(185, 20);
            this.EstadoEstadio_tb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado:";
            // 
            // Confirma_bt
            // 
            this.Confirma_bt.Location = new System.Drawing.Point(37, 190);
            this.Confirma_bt.Name = "Confirma_bt";
            this.Confirma_bt.Size = new System.Drawing.Size(75, 23);
            this.Confirma_bt.TabIndex = 6;
            this.Confirma_bt.Text = "Confirma";
            this.Confirma_bt.UseVisualStyleBackColor = true;
            this.Confirma_bt.Click += new System.EventHandler(this.Confirma_bt_Click);
            // 
            // edit_bt
            // 
            this.edit_bt.Location = new System.Drawing.Point(138, 190);
            this.edit_bt.Name = "edit_bt";
            this.edit_bt.Size = new System.Drawing.Size(75, 23);
            this.edit_bt.TabIndex = 8;
            this.edit_bt.Text = "Editar";
            this.edit_bt.UseVisualStyleBackColor = true;
            this.edit_bt.Click += new System.EventHandler(this.edit_bt_Click);
            // 
            // EditEstadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(245, 235);
            this.Controls.Add(this.edit_bt);
            this.Controls.Add(this.Confirma_bt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EstadoEstadio_tb);
            this.Controls.Add(this.cidadeestadio_tb);
            this.Controls.Add(this.nomeEstadio_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditEstadio";
            this.Text = "Estadio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeEstadio_tb;
        private System.Windows.Forms.TextBox cidadeestadio_tb;
        private System.Windows.Forms.TextBox EstadoEstadio_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Confirma_bt;
        private System.Windows.Forms.Button edit_bt;
    }
}