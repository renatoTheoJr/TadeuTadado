namespace TadeuTadado
{
    partial class frmTeste
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
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.cmbResposta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(12, 12);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(601, 335);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
            // 
            // cmbResposta
            // 
            this.cmbResposta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResposta.FormattingEnabled = true;
            this.cmbResposta.Items.AddRange(new object[] {
            "A)",
            "B)",
            "C)",
            "D)",
            "E)"});
            this.cmbResposta.Location = new System.Drawing.Point(48, 394);
            this.cmbResposta.Name = "cmbResposta";
            this.cmbResposta.Size = new System.Drawing.Size(121, 21);
            this.cmbResposta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resposta:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(192, 426);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(226, 28);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Ao clicar em continuar não será possivel retornar e modificar sua resposta.";
            // 
            // frmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbResposta);
            this.Controls.Add(this.picImagem);
            this.Name = "frmTeste";
            this.Text = "frmTeste";
            this.Load += new System.EventHandler(this.frmTeste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.ComboBox cmbResposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label label2;
    }
}