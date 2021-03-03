namespace TadeuTadado
{
    partial class frmPerguntas
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
            this.btnContinuar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(280, 418);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(226, 28);
            this.btnContinuar.TabIndex = 7;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resposta:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A)",
            "B)",
            "C)",
            "D)",
            "E)"});
            this.comboBox1.Location = new System.Drawing.Point(136, 386);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(100, 4);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(601, 335);
            this.picImagem.TabIndex = 4;
            this.picImagem.TabStop = false;
            // 
            // frmPerguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.picImagem);
            this.Name = "frmPerguntas";
            this.Text = "frmPerguntas";
            this.Load += new System.EventHandler(this.frmPerguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox picImagem;
    }
}